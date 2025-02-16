﻿using BlueprintCore.Actions.Builder;
using BlueprintCore.Actions.Builder.ContextEx;
using BlueprintCore.Blueprints.Configurators.Classes;
using BlueprintCore.Blueprints.Configurators.Classes.Selection;
using BlueprintCore.Blueprints.Configurators.UnitLogic.ActivatableAbilities;
using BlueprintCore.Blueprints.CustomConfigurators.Classes.Selection;
using BlueprintCore.Blueprints.CustomConfigurators.UnitLogic.Abilities;
using BlueprintCore.Blueprints.CustomConfigurators.UnitLogic.Buffs;
using BlueprintCore.Blueprints.ModReferences;
using BlueprintCore.Blueprints.References;
using BlueprintCore.Conditions.Builder;
using BlueprintCore.Conditions.Builder.ContextEx;
using BlueprintCore.Utils;
using BlueprintCore.Utils.Types;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.Blueprints.Classes.Selection;
using Kingmaker.Designers.Mechanics.Facts;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using Kingmaker.UnitLogic.Abilities.Components;
using Kingmaker.UnitLogic.ActivatableAbilities;
using Kingmaker.UnitLogic.Buffs.Blueprints;
using Kingmaker.UnitLogic.FactLogic;
using Kingmaker.UnitLogic.Mechanics;
using System.Collections.Generic;
using System.Linq;
using static Kingmaker.UnitLogic.Commands.Base.UnitCommand;

namespace BlueprintCore.Blueprints.CustomConfigurators.Classes
{
  /// <summary>
  /// Configurator for <see cref="BlueprintFeature"/>.
  /// </summary>
  /// <inheritdoc/>
  public class FeatureConfigurator
    : BaseFeatureConfigurator<BlueprintFeature, FeatureConfigurator>
  {
    private FeatureConfigurator(Blueprint<BlueprintReference<BlueprintFeature>> blueprint) : base(blueprint) { }

    private bool SkipSelections = false;
    private bool IsTeamworkFeat = false;

    private string CavalierBuffGuid = string.Empty;

    private string VanguardBuffGuid = string.Empty;
    private string VanguardAbilityGuid = string.Empty;

    private string PackRagerBuffGuid = string.Empty;
    private string PackRagerAreaGuid = string.Empty;
    private string PackRagerAreaBuffGuid = string.Empty;
    private string PackRagerToggleBuffGuid = string.Empty;
    private string PackRagerToggleGuid = string.Empty;

    /// <summary>
    /// Returns a configurator to modify the specified blueprint.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Use this to modify existing blueprints, such as blueprints from the base game.
    /// </para>
    /// <para>
    /// If you're using <see href="https://github.com/OwlcatOpenSource/WrathModificationTemplate">WrathModificationTemplate</see> blueprints defined in JSON already exist.
    /// </para>
    /// </remarks>
    /// <param name="updateSelections">If true, automatically adds the blueprint to feature selections with a matching group. Defaults to false.</param>
    public static FeatureConfigurator For(
      Blueprint<BlueprintReference<BlueprintFeature>> blueprint,
      bool updateSelections = false)
    {
      var configurator = new FeatureConfigurator(blueprint);
      return updateSelections ? configurator : configurator.SkipAddToSelections();
    }

    /// <summary>
    /// Creates a new blueprint and returns a new configurator to modify it.
    /// </summary>
    /// 
    /// <remarks>
    /// <example>
    /// Use <paramref name="groups"/> to specify which <c>BlueprintFeatureSelection</c> lists should contain the
    /// feature. In the following example the feature is included in
    /// <see cref="FeatureSelectionRefs.BasicFeatSelection"/> as well as any selection referencing <c>CombatFeat</c>
    /// e.g. <see cref="FeatureSelectionRefs.FighterFeatSelection"/>.
    /// 
    /// <code>
    /// FeatureConfigurator.New(CombatFeatName, CombatFeatGuid, FeatureGroup.Feat, FeatureGroup.CombatFeat)
    ///   .Configure();
    /// </code>
    /// </example>
    /// 
    /// <para>
    /// If FeatureGroup.TeamworkFeat is specified you should call <see cref="AddAsTeamworkFeat(string, string, string, string, string, string, string, string)"/>
    /// to make sure it functions correctly with all character features that share teamwork feats.
    /// </para>
    /// 
    /// <para>
    /// If you specify FeatureGroups it will automatically set <c>IsClassFeature</c> to <c>true</c> unless you include
    /// a group related to race or background:
    /// <list type="bullet">
    ///  <item>FeatureGroup.Racial</item>
    ///  <item>FeatureGroup.Trait</item>
    ///  <item>FeatureGroup.CreatureType</item>
    ///  <item>FeatureGroup.AasimarHeritage</item>
    ///  <item>FeatureGroup.TieflingHeritage</item>
    ///  <item>FeatureGroup.BackgroundSelection</item>
    ///  <item>FeatureGroup.DhampirHeritage</item>
    ///  <item>FeatureGroup.OreadHeritage</item>
    ///  <item>FeatureGroup.KitsuneHeritage</item>
    ///  <item>FeatureGroup.HalfOrcHeritage</item>
    /// </list>
    /// You can override this by calling <see cref="BaseFeatureConfigurator{T, TBuilder}.SetIsClassFeature(bool)"/>.
    /// </para>
    /// </remarks>
    /// 
    /// <param name="groups">
    /// When configured the feature is added to each <c>BlueprintFeatureSelection</c> with a matching <c>Group</c> or
    /// <c>Group2</c>.
    /// </param>
    public static FeatureConfigurator New(string name, string guid, params FeatureGroup[] groups)
    {
      BlueprintTool.Create<BlueprintFeature>(name, guid);
      var configurator = For(name, updateSelections: true);
      if (groups.Any())
      {
        configurator.SetGroups(groups);
        if (IsClassFeature(groups))
          configurator.SetIsClassFeature();
      }
      return configurator;
    }

    /// <summary>
    /// Call this to skip the automatic processing of <c>FeatureGroup</c> to add this feature to selections. Useful if
    /// you are using <c>BlueprintFeatureSelection</c> for a feat so the selected option can have
    /// <c>FeatureGroup.Feat</c> but only show under the selection.
    /// </summary>
    public FeatureConfigurator SkipAddToSelections()
    {
      SkipSelections = true;
      return this;
    }

    /// <summary>
    /// Populates all the necessary blueprints to make sure the teamwork feat is shared appropriately by various class
    /// and archetype abilities.
    /// </summary>
    /// 
    /// <remarks>
    /// <para>
    /// **IMPORTANT**: This generates blueprints using these GUIDs. That means they are a save dependency just like any
    /// other blueprint you create. Once you start using these you cannot stop, or you'll at least need to create
    /// dummy blueprints in their place.
    /// </para>
    /// 
    /// <para>
    /// If you only set <c>FeatureGroup.TeamworkFeat</c> Monster Tactician, Tactical Leader, Hunter Tactics, Sacred
    /// Huntsmaster Tactics, and Battle Prowess are configured automatically. This function is required to update
    /// Raging Tactician, Cavalier Tactics, and Vanguard Tactician which all require additional blueprints.
    /// </para>
    /// 
    /// <para>
    /// All created blueprints will inherit the name, description, and icon from this feature.
    /// </para>
    /// </remarks>
    /// 
    /// <param name="cavalierBuffGuid">Used to generate a buff which applies the feat for Cavalier Tactician.</param>
    /// 
    /// <param name="vanguardBuffGuid">Used to generate a buff which applies the feat for Vanguard Tactician.</param>
    /// <param name="vanguardAbilityGuid">Used to generate an ability which applies the vanguard buff.</param>
    /// 
    /// <param name="packRagerBuffGuid">Used to generate a buff which applies the feat for Raging Tactician.</param>
    /// <param name="packRagerAreaGuid">Used to generate an area which applies the pack rager buff.</param>
    /// <param name="packRagerAreaBuffGuid">Used to generate a buff which creates the pack rager area.</param>
    /// <param name="packRagerToggleBuffGuid">Used to generate a buff which turns on the pack rager area buff.</param>
    /// <param name="packRagerToggleGuid">Used to generate an ability which toggles the pack rager toggle buff.</param>
    public FeatureConfigurator AddAsTeamworkFeat(
      string cavalierBuffGuid,

      string vanguardBuffGuid,
      string vanguardAbilityGuid,

      string packRagerBuffGuid,
      string packRagerAreaGuid,
      string packRagerAreaBuffGuid,
      string packRagerToggleBuffGuid,
      string packRagerToggleGuid)
    {
      IsTeamworkFeat = true;

      CavalierBuffGuid = cavalierBuffGuid;

      VanguardBuffGuid = vanguardBuffGuid;
      VanguardAbilityGuid = vanguardAbilityGuid;

      PackRagerBuffGuid = packRagerBuffGuid;
      PackRagerAreaGuid = packRagerAreaGuid;
      PackRagerAreaBuffGuid = packRagerAreaBuffGuid;
      PackRagerToggleBuffGuid = packRagerToggleBuffGuid;
      PackRagerToggleGuid = packRagerToggleGuid;
      return this;
    }

    /// <summary>
    /// Adds the feature to specified ranger styles. Note that you only need to specify the minimum level for each
    /// category.
    /// </summary>
    public FeatureConfigurator AddToRangerStyles(params RangerStyle[] styles)
    {
      foreach (var style in styles)
      {
        switch (style)
        {
          case RangerStyle.Archery10:
            AdditionalFeatureSelections.Add(
              FeatureSelectionRefs.RangerStyleArcherySelection10.Cast<BlueprintFeatureSelectionReference>().Reference);
            goto case RangerStyle.Archery6;
          case RangerStyle.Archery6:
            AdditionalFeatureSelections.Add(
              FeatureSelectionRefs.RangerStyleArcherySelection6.Cast<BlueprintFeatureSelectionReference>().Reference);
            goto case RangerStyle.Archery2;
          case RangerStyle.Archery2:
            AdditionalFeatureSelections.Add(
              FeatureSelectionRefs.RangerStyleArcherySelection2.Cast<BlueprintFeatureSelectionReference>().Reference);
            break;

          case RangerStyle.Menacing10:
            AdditionalFeatureSelections.Add(
              FeatureSelectionRefs.RangerStyleMenacingSelection10.Cast<BlueprintFeatureSelectionReference>().Reference);
            goto case RangerStyle.Menacing6;
          case RangerStyle.Menacing6:
            AdditionalFeatureSelections.Add(
              FeatureSelectionRefs.RangerStyleMenacingSelection6.Cast<BlueprintFeatureSelectionReference>().Reference);
            goto case RangerStyle.Menacing2;
          case RangerStyle.Menacing2:
            AdditionalFeatureSelections.Add(
              FeatureSelectionRefs.RangerStyleMenacingSelection2.Cast<BlueprintFeatureSelectionReference>().Reference);
            break;

          case RangerStyle.Shield10:
            AdditionalFeatureSelections.Add(
              FeatureSelectionRefs.RangerStyleShieldSelection10.Cast<BlueprintFeatureSelectionReference>().Reference);
            goto case RangerStyle.Shield6;
          case RangerStyle.Shield6:
            AdditionalFeatureSelections.Add(
              FeatureSelectionRefs.RangerStyleShieldSelection6.Cast<BlueprintFeatureSelectionReference>().Reference);
            goto case RangerStyle.Shield2;
          case RangerStyle.Shield2:
            AdditionalFeatureSelections.Add(
              FeatureSelectionRefs.RangerStyleShieldSelection2.Cast<BlueprintFeatureSelectionReference>().Reference);
            break;

          case RangerStyle.TwoHanded10:
            AdditionalFeatureSelections.Add(
              FeatureSelectionRefs.RangerStyleTwoHandedSelection10.Cast<BlueprintFeatureSelectionReference>().Reference);
            goto case RangerStyle.TwoHanded6;
          case RangerStyle.TwoHanded6:
            AdditionalFeatureSelections.Add(
              FeatureSelectionRefs.RangerStyleTwoHandedSelection6.Cast<BlueprintFeatureSelectionReference>().Reference);
            goto case RangerStyle.TwoHanded2;
          case RangerStyle.TwoHanded2:
            AdditionalFeatureSelections.Add(
              FeatureSelectionRefs.RangerStyleTwoHandedSelection2.Cast<BlueprintFeatureSelectionReference>().Reference);
            break;

          case RangerStyle.TwoWeapon10:
            AdditionalFeatureSelections.Add(
              FeatureSelectionRefs.RangerStyleTwoWeaponSelection10.Cast<BlueprintFeatureSelectionReference>().Reference);
            goto case RangerStyle.TwoWeapon6;
          case RangerStyle.TwoWeapon6:
            AdditionalFeatureSelections.Add(
              FeatureSelectionRefs.RangerStyleTwoWeaponSelection6.Cast<BlueprintFeatureSelectionReference>().Reference);
            goto case RangerStyle.TwoWeapon2;
          case RangerStyle.TwoWeapon2:
            AdditionalFeatureSelections.Add(
              FeatureSelectionRefs.RangerStyleTwoWeaponSelection2.Cast<BlueprintFeatureSelectionReference>().Reference);
            break;
        }
      }
      return this;
    }

    /// <summary>
    /// Adds the feature to the specified selections, if the selections exist.
    /// </summary>
    /// 
    /// <remarks>
    /// <para>
    /// Most selections should be automatically populated based on the FeatureGroup values you specify in
    /// <see cref="New(string, string, FeatureGroup[])"/>.
    /// </para>
    /// 
    /// <para>
    /// Note that if a selection you provide here does not exist, it will not fail. Use this to add your feature to
    /// selections from other mods without a dependency: call
    /// <see cref="RootConfigurator{T, TBuilder}.Configure(bool)"/> setting <c>delayed</c> to <c>true</c>. Then when
    /// you call <see cref="RootConfigurator{T, TBuilder}.ConfigureDelayedBlueprints"/> those selections should exist
    /// if the required mod is installed.
    /// </para>
    /// </remarks>
    public FeatureConfigurator AddToFeatureSelection(params Blueprint<BlueprintFeatureSelectionReference>[] selections)
    {
      foreach (var selection in selections)
      {
        AdditionalFeatureSelections.Add(selection.Reference);
      }
      return this;
    }

    private static readonly IEnumerable<BlueprintFeatureSelection> FeatureSelections =
      FeatureSelectionRefs.All.Select(selectionRef => selectionRef.Reference.Get()).Where(s => s is not null);

    private readonly HashSet<BlueprintFeatureSelectionReference> AdditionalFeatureSelections = new();
    protected override void OnConfigureCompleted()
    {
      base.OnConfigureCompleted();

      if (SkipSelections || !Configured)
        return;

      PopulateSelections(
        Blueprint,
        AdditionalFeatureSelections,
        IsTeamworkFeat,
        cavalierBuffGuid: CavalierBuffGuid,
        vanguardBuffGuid: VanguardBuffGuid,
        vanguardAbilityGuid: VanguardAbilityGuid,
        packRagerBuffGuid: PackRagerBuffGuid,
        packRagerAreaGuid: PackRagerAreaGuid,
        packRagerAreaBuffGuid: PackRagerAreaBuffGuid,
        packRagerToggleBuffGuid: PackRagerToggleBuffGuid,
        packRagerToggleGuid: PackRagerToggleGuid);
    }

    internal static void PopulateSelections(
      BlueprintFeature blueprint,
      HashSet<BlueprintFeatureSelectionReference> additionalSelections,
      bool forceTeamworkFeat,
      string cavalierBuffGuid,
      string vanguardBuffGuid,
      string vanguardAbilityGuid,
      string packRagerBuffGuid,
      string packRagerAreaGuid,
      string packRagerAreaBuffGuid,
      string packRagerToggleBuffGuid,
      string packRagerToggleGuid)
    {
      var additionalFeatureSelections = additionalSelections.Select(s => s.Get()).Where(s => s is not null);
      foreach (var selection in FeatureSelections.Except(additionalFeatureSelections))
      {
        if (selection.m_AllFeatures.Select(f => f.deserializedGuid).Contains(blueprint.AssetGuid))
          continue;
        if (blueprint.HasGroup(selection.Group, selection.Group2))
          FeatureSelectionConfigurator.For(selection).AddToAllFeatures(blueprint).Configure();
      }

      var modFeatureSelections = ModFeatureSelectionRefs.All.Select(s => s.Reference.Get()).Where(s => s is not null);
      foreach (var selection in modFeatureSelections.Except(additionalFeatureSelections))
      {
        if (selection.m_AllFeatures.Select(f => f.deserializedGuid).Contains(blueprint.AssetGuid))
          continue;
        if (blueprint.HasGroup(selection.Group, selection.Group2))
          FeatureSelectionConfigurator.For(selection).AddToAllFeatures(blueprint).Configure();
      }

      foreach (var selection in additionalFeatureSelections)
        FeatureSelectionConfigurator.For(selection).AddToAllFeatures(blueprint).Configure();

      var isTeamworkFeat = forceTeamworkFeat || blueprint.HasGroup(FeatureGroup.TeamworkFeat);
      // Ensures that teamwork feats are shared by the various features
      if (isTeamworkFeat)
      {
        ParametrizedFeatureConfigurator.For(ParametrizedFeatureRefs.LichSkeletalTeamworkParametrized)
          .AddToBlueprintParameterVariants(blueprint)
          .Configure();

        AddFactsFromCaster(blueprint, BuffRefs.BattleProwessEffectBuff);
        AddFactsFromCaster(blueprint, BuffRefs.MonsterTacticsBuff);
        AddFactsFromCaster(blueprint, BuffRefs.TacticalLeaderFeatShareBuff);

        ShareFeatureWithPet(blueprint, FeatureRefs.HunterTactics);
        ShareFeatureWithPet(blueprint, FeatureRefs.SacredHuntsmasterTactics);

        #region Cavalier Tactician
        var cavalierBuff = BuffConfigurator.New($"CavalierTactician_{blueprint.name}_Buff", cavalierBuffGuid)
          .SetDisplayName(blueprint.m_DisplayName)
          .SetDescription(blueprint.m_Description)
          .SetIcon(blueprint.Icon)
          .SetIsClassFeature()
          .SetStacking(StackingType.Ignore)
          .AddFeatureIfHasFact(checkedFact: blueprint, feature: blueprint, not: true)
          .Configure();

        AddBuffToAbilityApplyFact(cavalierBuff, AbilityRefs.CavalierTacticianAbility);
        AddBuffToAbilityApplyFact(cavalierBuff, AbilityRefs.CavalierTacticianAbilitySwift);

        FeatureConfigurator.For(FeatureRefs.CavalierTacticianSupportFeature)
          .AddFeatureIfHasFact(checkedFact: blueprint, feature: cavalierBuff)
          .Configure();
        #endregion

        #region Vanguard Tactician
        var vanguardBuff = BuffConfigurator.New($"VanguardTactician_{blueprint.name}_Buff", vanguardBuffGuid)
          .SetDisplayName(blueprint.m_DisplayName)
          .SetDescription(blueprint.m_Description)
          .SetIcon(blueprint.Icon)
          .SetIsClassFeature()
          .AddFactsFromCaster(facts: new() { blueprint })
          .Configure();

        var vanguardAbility =
          AbilityConfigurator.New($"VanguardTactician_{blueprint.name}_Ability", vanguardAbilityGuid)
            .SetDisplayName(blueprint.m_DisplayName)
            .SetDescription(blueprint.m_Description)
            .SetIcon(blueprint.Icon)
            .SetRange(AbilityRange.Personal)
            .SetType(AbilityType.Extraordinary)
            .SetParent(AbilityRefs.VanguardTacticianBaseAbility.ToString())
            .AddAbilityEffectRunAction(
              ActionsBuilder.New()
                .Conditional(
                  ConditionsBuilder.New().HasFact(blueprint, negate: true),
                  ifTrue:
                    ActionsBuilder.New().ApplyBuff(vanguardBuff, ContextDuration.Variable(ContextValues.Rank()))))
            .AddContextRankConfig(
              ContextRankConfigs.ClassLevel(new string[] { CharacterClassRefs.SlayerClass.ToString() })
                .WithDiv2Progression(3))
            .AddAbilityTargetsAround(targetType: TargetType.Ally, radius: new(30))
            .AddAbilityShowIfCasterHasFact(unitFact: blueprint)
            .AddAbilityResourceLogic(
              isSpendResource: true, requiredResource: AbilityResourceRefs.VanguardTacticianResource.ToString())
            .Configure();

        AbilityConfigurator.For(AbilityRefs.VanguardTacticianBaseAbility)
          .EditComponent<AbilityVariants>(
            c => c.m_Variants =
              CommonTool.Append(c.m_Variants, vanguardAbility.ToReference<BlueprintAbilityReference>()))
          .Configure();
        #endregion

        #region PackRager
        var icon = ActivatableAbilityRefs.PackRagerAlliedSpellcasterToggleAbility.Reference.Get().Icon;
        var ragerBuff = BuffConfigurator.New($"PackRager_{blueprint.name}_Buff", packRagerBuffGuid)
          .SetDisplayName(blueprint.m_DisplayName)
          .SetDescription(blueprint.m_Description)
          .SetIcon(icon)
          .SetIsClassFeature()
          .AddToFlags(BlueprintBuff.Flags.StayOnDeath)
          .SetFrequency(DurationRate.Minutes)
          .AddTemporaryFeat(blueprint)
          .Configure();

        var ragerArea = AbilityAreaEffectConfigurator.New($"PackRager_{blueprint.name}_Area", packRagerAreaGuid)
          .SetAggroEnemies(false)
          .SetTargetType(BlueprintAbilityAreaEffect.TargetType.Ally)
          .AddAbilityAreaEffectRunAction(
            unitEnter: ActionsBuilder.New().ApplyBuffPermanent(ragerBuff),
            unitExit: ActionsBuilder.New().RemoveBuff(ragerBuff))
          .SetSize(new(50))
          .SetShape(AreaEffectShape.Cylinder)
          .Configure();

        var ragerAreaBuff = BuffConfigurator.New($"PackRager_{blueprint.name}_AreaBuff", packRagerAreaBuffGuid)
          .SetIcon(icon)
          .SetIsClassFeature()
          .AddToFlags(BlueprintBuff.Flags.StayOnDeath)
          .AddAreaEffect(areaEffect: ragerArea)
          .Configure();

        var ragerToggleBuff = BuffConfigurator.New($"PackRager_{blueprint.name}_ToggleBuff", packRagerToggleBuffGuid)
          .SetIcon(icon)
          .SetIsClassFeature()
          .AddToFlags(BlueprintBuff.Flags.StayOnDeath)
          .AddBuffExtraEffects(checkedBuff: BuffRefs.StandartRageBuff.ToString(), extraEffectBuff: ragerAreaBuff)
          .Configure();

        var ragerToggle = ActivatableAbilityConfigurator.New($"PackRager_{blueprint.name}_Toggle", packRagerToggleGuid)
          .SetDisplayName(blueprint.m_DisplayName)
          .SetDescription(blueprint.m_Description)
          .SetIcon(icon)
          .SetIsOnByDefault()
          .SetActivateWithUnitCommand(CommandType.Standard)
          .SetGroup(ActivatableAbilityGroup.RagingTactician)
          .SetBuff(ragerToggleBuff)
          .Configure();

        FeatureConfigurator.For(FeatureRefs.PackRagerRagingTacticianBaseFeature)
          .AddFeatureIfHasFact(checkedFact: blueprint, feature: ragerToggle)
          .Configure();
        #endregion
      }
    }

    private static void AddFactsFromCaster(BlueprintFeature blueprint, Blueprint<BlueprintReference<BlueprintBuff>> buff)
    {
      BuffConfigurator.For(buff)
          .EditComponent<AddFactsFromCaster>(
            c => c.m_Facts = CommonTool.Append(c.m_Facts, blueprint.ToReference<BlueprintUnitFactReference>()))
          .Configure();
    }

    private static void ShareFeatureWithPet(BlueprintFeature blueprint, Blueprint<BlueprintReference<BlueprintFeature>> feature)
    {
      FeatureConfigurator.For(feature)
        .EditComponent<ShareFeaturesWithPet>(
          c => c.m_Features = CommonTool.Append(c.m_Features, blueprint.ToReference<BlueprintFeatureReference>()))
        .Configure();
    }

    private static void AddBuffToAbilityApplyFact(BlueprintBuff buff, Blueprint<BlueprintReference<BlueprintAbility>> ability)
    {
      AbilityConfigurator.For(ability)
        .EditComponent<AbilityApplyFact>(
          c => c.m_Facts = CommonTool.Append(c.m_Facts, buff.ToReference<BlueprintUnitFactReference>()))
        .Configure();
    }

    internal static bool IsClassFeature(FeatureGroup[] groups)
    {
      if (groups.Contains(FeatureGroup.Racial))
        return false;
      if (groups.Contains(FeatureGroup.Trait))
        return false;
      if (groups.Contains(FeatureGroup.CreatureType))
        return false;
      if (groups.Contains(FeatureGroup.AasimarHeritage))
        return false;
      if (groups.Contains(FeatureGroup.TieflingHeritage))
        return false;
      if (groups.Contains(FeatureGroup.BackgroundSelection))
        return false;
      if (groups.Contains(FeatureGroup.DhampirHeritage))
        return false;
      if (groups.Contains(FeatureGroup.OreadHeritage))
        return false;
      if (groups.Contains(FeatureGroup.KitsuneHeritage))
        return false;
      if (groups.Contains(FeatureGroup.HalfOrcHeritage))
        return false;

      return true;
    }
  }

  /// <summary>
  /// Use with <see cref="FeatureConfigurator.AddToRangerStyles(RangerStyle[])"/> to add to the appropriate ranger
  /// style feat selection. 
  /// </summary>
  /// 
  /// <remarks>
  /// The ending number indicates the level it becomes available. It is automatically added to higher level lists.
  /// e.g. <c>AddToRangerStyles(RangerStyle.Archery2)</c> adds the feature to RangerStyleArcherySelection2,
  /// RangerStyleArcherySelection6, and RangerStyleArcherySelection10.
  /// </remarks>
  public enum RangerStyle
  {
    Archery2,
    Archery6,
    Archery10,

    Menacing2,
    Menacing6,
    Menacing10,

    Shield2,
    Shield6,
    Shield10,

    TwoHanded2,
    TwoHanded6,
    TwoHanded10,

    TwoWeapon2,
    TwoWeapon6,
    TwoWeapon10,
  }
}

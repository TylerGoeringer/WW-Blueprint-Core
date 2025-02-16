//***** AUTO-GENERATED - DO NOT EDIT *****//

using BlueprintCore.Actions.Builder;
using BlueprintCore.Blueprints.Components.Replacements;
using BlueprintCore.Blueprints.Configurators.Facts;
using BlueprintCore.Blueprints.CustomConfigurators;
using BlueprintCore.Utils;
using BlueprintCore.Utils.Assets;
using BlueprintCore.Utils.Types;
using Kingmaker.Armies.TacticalCombat.Brain;
using Kingmaker.Armies.TacticalCombat.Components;
using Kingmaker.Armies.TacticalCombat.LeaderSkills;
using Kingmaker.Armies.TacticalCombat.LeaderSkills.UnitBuffComponents;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.Blueprints.Classes.Spells;
using Kingmaker.Blueprints.Facts;
using Kingmaker.Blueprints.Items.Ecnchantments;
using Kingmaker.Blueprints.Items.Equipment;
using Kingmaker.Blueprints.Items.Weapons;
using Kingmaker.Corruption;
using Kingmaker.Designers.Mechanics.Buffs;
using Kingmaker.Designers.Mechanics.Buffs.HalfOfPair;
using Kingmaker.Designers.Mechanics.Facts;
using Kingmaker.Designers.Mechanics.Facts.Restrictions;
using Kingmaker.ElementsSystem;
using Kingmaker.EntitySystem.Stats;
using Kingmaker.Enums;
using Kingmaker.Enums.Damage;
using Kingmaker.ResourceLinks;
using Kingmaker.RuleSystem;
using Kingmaker.RuleSystem.Rules;
using Kingmaker.UI.GenericSlot;
using Kingmaker.UnitLogic.Abilities;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using Kingmaker.UnitLogic.Abilities.Components;
using Kingmaker.UnitLogic.ActivatableAbilities;
using Kingmaker.UnitLogic.Buffs;
using Kingmaker.UnitLogic.Buffs.Blueprints;
using Kingmaker.UnitLogic.Buffs.Components;
using Kingmaker.UnitLogic.Class;
using Kingmaker.UnitLogic.Class.Kineticist;
using Kingmaker.UnitLogic.FactLogic;
using Kingmaker.UnitLogic.Mechanics;
using Kingmaker.UnitLogic.Mechanics.Actions;
using Kingmaker.UnitLogic.Mechanics.Components;
using Kingmaker.UnitLogic.Mechanics.Properties;
using Kingmaker.UnitLogic.Parts;
using Kingmaker.Utility;
using Kingmaker.Visual;
using Kingmaker.Visual.Animation.Kingmaker.Actions;
using Kingmaker.Visual.HitSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace BlueprintCore.Blueprints.Configurators.UnitLogic.Buffs
{
  /// <summary>
  /// Implements common fields and components for blueprints inheriting from <see cref="BlueprintBuff"/>.
  /// </summary>
  /// <inheritdoc/>
  public abstract class BaseBuffConfigurator<T, TBuilder>
    : BaseUnitFactConfigurator<T, TBuilder>
    where T : BlueprintBuff
    where TBuilder : BaseBuffConfigurator<T, TBuilder>
  {
    protected BaseBuffConfigurator(Blueprint<BlueprintReference<T>> blueprint) : base(blueprint) { }

    /// <inheritdoc cref="RootConfigurator{T, TBuilder}.CopyFrom(Blueprint{BlueprintReference{BlueprintScriptableObject}}, Type[])"/>
    public TBuilder CopyFrom(
      Blueprint<BlueprintReference<BlueprintBuff>> blueprint, params Type[] componentTypes)
    {
      base.CopyFrom(blueprint.ToString(), componentTypes);
    
      return OnConfigureInternal(
        bp =>
        {
          var copyFrom = blueprint.Reference.Get();
          bp.Stacking = copyFrom.Stacking;
          bp.IsClassFeature = copyFrom.IsClassFeature;
          bp.m_Flags = copyFrom.m_Flags;
          bp.Ranks = copyFrom.Ranks;
          bp.TickEachSecond = copyFrom.TickEachSecond;
          bp.Frequency = copyFrom.Frequency;
          bp.FxOnStart = copyFrom.FxOnStart;
          bp.FxOnRemove = copyFrom.FxOnRemove;
          bp.ResourceAssetIds = copyFrom.ResourceAssetIds;
          bp.EmulateAbilityContext = copyFrom.EmulateAbilityContext;
        });
    }

    /// <inheritdoc cref="RootConfigurator{T, TBuilder}.CopyFrom(Blueprint{BlueprintReference{BlueprintScriptableObject}}, Predicate{BlueprintComponent})"/>
    public TBuilder CopyFrom(
      Blueprint<BlueprintReference<BlueprintBuff>> blueprint, Predicate<BlueprintComponent> componentMatcher)
    {
      base.CopyFrom(blueprint.ToString(), componentMatcher);
    
      return OnConfigureInternal(
        bp =>
        {
          var copyFrom = blueprint.Reference.Get();
          bp.Stacking = copyFrom.Stacking;
          bp.IsClassFeature = copyFrom.IsClassFeature;
          bp.m_Flags = copyFrom.m_Flags;
          bp.Ranks = copyFrom.Ranks;
          bp.TickEachSecond = copyFrom.TickEachSecond;
          bp.Frequency = copyFrom.Frequency;
          bp.FxOnStart = copyFrom.FxOnStart;
          bp.FxOnRemove = copyFrom.FxOnRemove;
          bp.ResourceAssetIds = copyFrom.ResourceAssetIds;
          bp.EmulateAbilityContext = copyFrom.EmulateAbilityContext;
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintBuff.Stacking"/>
    /// </summary>
    /// <remarks>
    /// <para>
    /// Use <see cref="SetRanks(int)"/> for StackingType.Rank.
    /// </para>
    /// </remarks>
    ///
    /// <param name="stacking">
    /// <para>
    /// InfoBox: Replace - New buff removes existing buff and takes its place  Prolong - Existing buff duration get prolonged, new buff is otherwise ignored  Ignore - New buff is ignored  Stack - Both buffs are added and function independently  Poison - Special stacking type for poison  Summ - Duration is added to current duration  Rank - For buffs with limited stack
    /// </para>
    /// </param>
    public TBuilder SetStacking(StackingType stacking)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.Stacking = stacking;
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintBuff.IsClassFeature"/>
    /// </summary>
    public TBuilder SetIsClassFeature(bool isClassFeature = true)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.IsClassFeature = isClassFeature;
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintBuff.m_Flags"/>
    /// </summary>
    public TBuilder SetFlags(params BlueprintBuff.Flags[] flags)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_Flags = flags.Aggregate((BlueprintBuff.Flags) 0, (f1, f2) => f1 | f2);
        });
    }

    /// <summary>
    /// Adds to the contents of <see cref="BlueprintBuff.m_Flags"/>
    /// </summary>
    public TBuilder AddToFlags(params BlueprintBuff.Flags[] flags)
    {
      return OnConfigureInternal(
        bp =>
        {
          flags.ForEach(f => bp.m_Flags |= f);
        });
    }

    /// <summary>
    /// Removes elements from <see cref="BlueprintBuff.m_Flags"/>
    /// </summary>
    public TBuilder RemoveFromFlags(params BlueprintBuff.Flags[] flags)
    {
      return OnConfigureInternal(
        bp =>
        {
          flags.ForEach(f => bp.m_Flags &= ~f);
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintBuff.Ranks"/>
    /// </summary>
    public TBuilder SetRanks(int ranks)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.Ranks = ranks;
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintBuff.TickEachSecond"/>
    /// </summary>
    public TBuilder SetTickEachSecond(bool tickEachSecond = true)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.TickEachSecond = tickEachSecond;
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintBuff.Frequency"/>
    /// </summary>
    public TBuilder SetFrequency(DurationRate frequency)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.Frequency = frequency;
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintBuff.FxOnStart"/>
    /// </summary>
    ///
    /// <param name="fxOnStart">
    /// You can pass in the animation using a PrefabLink or it's AssetId.
    /// </param>
    public TBuilder SetFxOnStart(AssetLink<PrefabLink> fxOnStart)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.FxOnStart = fxOnStart?.Get();
        });
    }

    /// <summary>
    /// Modifies <see cref="BlueprintBuff.FxOnStart"/> by invoking the provided action.
    /// </summary>
    public TBuilder ModifyFxOnStart(Action<PrefabLink> action)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.FxOnStart is null) { return; }
          action.Invoke(bp.FxOnStart);
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintBuff.FxOnRemove"/>
    /// </summary>
    ///
    /// <param name="fxOnRemove">
    /// You can pass in the animation using a PrefabLink or it's AssetId.
    /// </param>
    public TBuilder SetFxOnRemove(AssetLink<PrefabLink> fxOnRemove)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.FxOnRemove = fxOnRemove?.Get();
        });
    }

    /// <summary>
    /// Modifies <see cref="BlueprintBuff.FxOnRemove"/> by invoking the provided action.
    /// </summary>
    public TBuilder ModifyFxOnRemove(Action<PrefabLink> action)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.FxOnRemove is null) { return; }
          action.Invoke(bp.FxOnRemove);
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintBuff.ResourceAssetIds"/>
    /// </summary>
    public TBuilder SetResourceAssetIds(params string[] resourceAssetIds)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.ResourceAssetIds = resourceAssetIds;
        });
    }

    /// <summary>
    /// Adds to the contents of <see cref="BlueprintBuff.ResourceAssetIds"/>
    /// </summary>
    public TBuilder AddToResourceAssetIds(params string[] resourceAssetIds)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.ResourceAssetIds = bp.ResourceAssetIds ?? new string[0];
          bp.ResourceAssetIds = CommonTool.Append(bp.ResourceAssetIds, resourceAssetIds);
        });
    }

    /// <summary>
    /// Removes elements from <see cref="BlueprintBuff.ResourceAssetIds"/>
    /// </summary>
    public TBuilder RemoveFromResourceAssetIds(params string[] resourceAssetIds)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.ResourceAssetIds is null) { return; }
          bp.ResourceAssetIds = bp.ResourceAssetIds.Where(val => !resourceAssetIds.Contains(val)).ToArray();
        });
    }

    /// <summary>
    /// Removes elements from <see cref="BlueprintBuff.ResourceAssetIds"/> that match the provided predicate.
    /// </summary>
    public TBuilder RemoveFromResourceAssetIds(Func<string, bool> predicate)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.ResourceAssetIds is null) { return; }
          bp.ResourceAssetIds = bp.ResourceAssetIds.Where(e => !predicate(e)).ToArray();
        });
    }

    /// <summary>
    /// Removes all elements from <see cref="BlueprintBuff.ResourceAssetIds"/>
    /// </summary>
    public TBuilder ClearResourceAssetIds()
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.ResourceAssetIds = new string[0];
        });
    }

    /// <summary>
    /// Modifies <see cref="BlueprintBuff.ResourceAssetIds"/> by invoking the provided action on each element.
    /// </summary>
    public TBuilder ModifyResourceAssetIds(Action<string> action)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.ResourceAssetIds is null) { return; }
          bp.ResourceAssetIds.ForEach(action);
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintBuff.EmulateAbilityContext"/>
    /// </summary>
    public TBuilder SetEmulateAbilityContext(bool emulateAbilityContext = true)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.EmulateAbilityContext = emulateAbilityContext;
        });
    }

    /// <summary>
    /// Adds <see cref="AddContextStatBonus"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <para>
    /// ComponentName: Add stat bonus
    /// </para>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>Abrogail_Feature_Prebuff</term><description>f0cad5e5b57b49f8b0983392a8c72eea</description></item>
    /// <item><term>FinalWyrmshifterBlackBreathPenaltyBuff</term><description>4d6ccea8444744e88f5b3bd42e8538ab</description></item>
    /// <item><term>ZonKuthonScarHalfHPBuff</term><description>9a47f56d0a1f42d9bf820da1d78919a7</description></item>
    /// </list>
    /// </remarks>
    public TBuilder AddContextStatBonus(
        StatType stat,
        ContextValue value,
        ModifierDescriptor? descriptor = null,
        int? minimal = null,
        int? multiplier = null,
        RestrictionCalculator? restrictions = null)
    {
      var component = new AddContextStatBonus();
      component.Stat = stat;
      component.Value = value;
      component.Descriptor = descriptor ?? component.Descriptor;
      component.Minimal = minimal ?? component.Minimal;
      component.HasMinimal = minimal is null;
      component.Multiplier = multiplier ?? component.Multiplier;
      Validate(restrictions);
      component.Restrictions = restrictions ?? component.Restrictions;
      return AddComponent(component);
    }

    /// <summary>
    /// Adds <see cref="AddEffectFastHealing"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <para>
    /// ComponentName: Buffs/AddEffect/FastHealing
    /// </para>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>BlackLinnormStewBuff</term><description>4fbf48fff5bff9148accad55c116b8f2</description></item>
    /// <item><term>FocusCrystall_Feature_HealthHard</term><description>fe34c4009816484a9167c5635b0dfc96</description></item>
    /// <item><term>VrolikaiAspectFeature</term><description>0ed608f1a0695cd4cb80bf6d415ab295</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddEffectFastHealing(
        int heal,
        ContextValue? bonus = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new AddEffectFastHealing();
      component.Heal = heal;
      component.Bonus = bonus ?? component.Bonus;
      if (component.Bonus is null)
      {
        component.Bonus = ContextValues.Constant(0);
      }
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="ContextRankConfig"/>
    /// </summary>
    ///
    /// <remarks>
    /// <para>
    /// Use <see cref="Utils.Types.ContextRankConfigs"/> to create the ContextRankConfig component.
    /// </para>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>5_DeadStage_AcidBuff</term><description>b730dbbb5e8143abbba6a066bc82c19a</description></item>
    /// <item><term>HellsDecreeAbilityMagicNecromancyBuff</term><description>c695587d5307d234cb34f62750ff7616</description></item>
    /// <item><term>ZonKuthonScarBuff</term><description>fbb677d91f924b99a3610ae79f6468fa</description></item>
    /// </list>
    /// </remarks>
    public TBuilder AddContextRankConfig(ContextRankConfig component)
    {
      return AddComponent(component);
    }

    /// <summary>
    /// Adds <see cref="SpellDescriptorComponent"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>Abrikandilu_Frozen_Buff</term><description>b2df7031cdad480caddf962c894ca484</description></item>
    /// <item><term>Halaseliax_FireBreathWeapon</term><description>cef56b3867604e7394e61fcbeb51dae5</description></item>
    /// <item><term>ZachariusFearAuraBuff</term><description>4d9144b465bbefe4786cfe86c745ea4e</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddSpellDescriptorComponent(
        SpellDescriptorWrapper descriptor,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new SpellDescriptorComponent();
      component.Descriptor = descriptor;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="AddOutgoingDamageTriggerFixed"/>
    /// </summary>
    public TBuilder AddOutgoingDamageTriggerFixed(AddOutgoingDamageTriggerFixed component)
    {
      return AddComponent(component);
    }

    /// <summary>
    /// Adds <see cref="AddStatBonusIfHasFactFixed"/>
    /// </summary>
    public TBuilder AddStatBonusIfHasFactFixed(AddStatBonusIfHasFactFixed component)
    {
      return AddComponent(component);
    }

    /// <summary>
    /// Adds <see cref="GlobalMapSpeedModifier"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>DivineServiceSpeedModifier</term><description>23c769eaac4409742a786a157ea96273</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddGlobalMapSpeedModifier(
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        float? speedModifier = null)
    {
      var component = new GlobalMapSpeedModifier();
      component.SpeedModifier = speedModifier ?? component.SpeedModifier;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="ArmorWeightCoef"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>PurifierCelestialArmorFeature</term><description>7dc8d7dede2704640956f7bc4102760a</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddArmorWeightCoef(
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        float? weightCoef = null)
    {
      var component = new ArmorWeightCoef();
      component.WeightCoef = weightCoef ?? component.WeightCoef;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="ChangeHitFxType"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>DLC5_GiantBoss_State2_OverrideVisionRange</term><description>c7ca25b5d5f44122a49d6b1a8ad14d85</description></item>
    /// <item><term>DLC5_IceRockPolymorph</term><description>721418455899409689238f79ff1dc5df</description></item>
    /// <item><term>LannSparringBuff</term><description>0b87395f642f67048aafeaf65146edb0</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddChangeHitFxType(
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        BloodType? overrideBloodType = null)
    {
      var component = new ChangeHitFxType();
      component.OverrideBloodType = overrideBloodType ?? component.OverrideBloodType;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="AddForceMove"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>TsunamiBuff</term><description>1694ee72db34ecf49a63005e845e175d</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddForceMove(
        ContextValue? feetPerRound = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new AddForceMove();
      component.FeetPerRound = feetPerRound ?? component.FeetPerRound;
      if (component.FeetPerRound is null)
      {
        component.FeetPerRound = ContextValues.Constant(0);
      }
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="AddGoldenDragonSkillBonus"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <para>
    /// ComponentName: Add stat bonus
    /// </para>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>GoldenDragonSharedSkillUMD</term><description>4e0b919e4fbd85142bce959fae129d1a</description></item>
    /// </list>
    /// </remarks>
    public TBuilder AddGoldenDragonSkillBonus(
        ModifierDescriptor? descriptor = null,
        StatType? stat = null)
    {
      var component = new AddGoldenDragonSkillBonus();
      component.Descriptor = descriptor ?? component.Descriptor;
      component.Stat = stat ?? component.Stat;
      return AddComponent(component);
    }

    /// <summary>
    /// Adds <see cref="AddRestTrigger"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>ArcanistArcaneReservoirFeature</term><description>55db1859bd72fd04f9bd3fe1f10e4cbb</description></item>
    /// <item><term>MaskOfAreshkagalHeadband_TabulaRasaFeature</term><description>edf05f7d96dc4d59b7242c5985b2e6f7</description></item>
    /// <item><term>TricksterLoreNature3Feature</term><description>b88ca3a5476ebcc4ea63d5c1e92ce222</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddRestTrigger(
        ActionsBuilder? action = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new AddRestTrigger();
      component.Action = action?.Build() ?? component.Action;
      if (component.Action is null)
      {
        component.Action = Utils.Constants.Empty.Actions;
      }
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="AddRunwayLogic"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>SecretOfSubduingRunwayBuff</term><description>a4d60878d85d652489c5b0fd9b11e1ac</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddRunwayLogic(
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new AddRunwayLogic();
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="AddTemporaryFeat"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>Achaekek_Buff</term><description>b9c4527e6cfc4fc39f4abdc76f91e279</description></item>
    /// <item><term>PackRagerOutflankBuff</term><description>1defa80e957ceac46bc68be3d8afcce9</description></item>
    /// <item><term>TriceratopsStatuetteBuff</term><description>b0b20d062e5419a43b5c0c829cdfcd8d</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="feat">
    /// <para>
    /// Blueprint of type BlueprintFeature. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder AddTemporaryFeat(
        Blueprint<BlueprintFeatureReference>? feat = null)
    {
      var component = new AddTemporaryFeat();
      component.m_Feat = feat?.Reference ?? component.m_Feat;
      if (component.m_Feat is null)
      {
        component.m_Feat = BlueprintTool.GetRef<BlueprintFeatureReference>(null);
      }
      return AddComponent(component);
    }

    /// <summary>
    /// Adds <see cref="AddWeaponEnhancementBonusToStat"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>PerfectStormFeature</term><description>f93deb8fb11e06743b6941626cd6f2e0</description></item>
    /// </list>
    /// </remarks>
    public TBuilder AddWeaponEnhancementBonusToStat(
        ModifierDescriptor? descriptor = null,
        int? multiplier = null,
        StatType? stat = null)
    {
      var component = new AddWeaponEnhancementBonusToStat();
      component.Descriptor = descriptor ?? component.Descriptor;
      component.Multiplier = multiplier ?? component.Multiplier;
      component.Stat = stat ?? component.Stat;
      return AddComponent(component);
    }

    /// <summary>
    /// Adds <see cref="BuffEnchantArmor"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AasimarRedMask_MagicalVestmentArmorBuff</term><description>2d6f3b09fddf442da939f66c751b1b14</description></item>
    /// <item><term>Inquisitor_Liotr_MagicalVestmentShieldBuff</term><description>af3878638a198144faa4f8ff660c09a8</description></item>
    /// <item><term>MagicalVestmentShieldBuff</term><description>2e8446f820936a44f951b50d70a82b16</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="enchantments">
    /// <para>
    /// Blueprint of type BlueprintItemEnchantment. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder AddBuffEnchantArmor(
        List<Blueprint<BlueprintItemEnchantmentReference>>? enchantments = null,
        BuffEnchantArmor.ItemType? itemType = null,
        BuffScaling? scaling = null)
    {
      var component = new BuffEnchantArmor();
      component.m_Enchantments = enchantments?.Select(bp => bp.Reference)?.ToArray() ?? component.m_Enchantments;
      if (component.m_Enchantments is null)
      {
        component.m_Enchantments = new BlueprintItemEnchantmentReference[0];
      }
      component.m_ItemType = itemType ?? component.m_ItemType;
      Validate(scaling);
      component.m_Scaling = scaling ?? component.m_Scaling;
      return AddComponent(component);
    }

    /// <summary>
    /// Adds <see cref="BuffEnchantSpecificWeaponWorn"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>BlessedScriptBaneWeaponBuff</term><description>45628d9632fd42979c10f4eebad6fb41</description></item>
    /// <item><term>SorcerousClawsEnchantPlus4Buff</term><description>77028c4ec6194b7b84002c10d4e46618</description></item>
    /// <item><term>TheUndyingLoveOfTheHopebringer_LightNova_GiveBuff</term><description>8c9b07c246a3469e8c154d98ee594ee3</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="enchantmentBlueprint">
    /// <para>
    /// Blueprint of type BlueprintItemEnchantment. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    /// <param name="weaponBlueprint">
    /// <para>
    /// Blueprint of type BlueprintItemWeapon. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder AddBuffEnchantSpecificWeaponWorn(
        Blueprint<BlueprintItemEnchantmentReference>? enchantmentBlueprint = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        Blueprint<BlueprintItemWeaponReference>? weaponBlueprint = null)
    {
      var component = new BuffEnchantSpecificWeaponWorn();
      component.m_EnchantmentBlueprint = enchantmentBlueprint?.Reference ?? component.m_EnchantmentBlueprint;
      if (component.m_EnchantmentBlueprint is null)
      {
        component.m_EnchantmentBlueprint = BlueprintTool.GetRef<BlueprintItemEnchantmentReference>(null);
      }
      component.m_WeaponBlueprint = weaponBlueprint?.Reference ?? component.m_WeaponBlueprint;
      if (component.m_WeaponBlueprint is null)
      {
        component.m_WeaponBlueprint = BlueprintTool.GetRef<BlueprintItemWeaponReference>(null);
      }
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="BuffEnchantWornItem"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AlignWeaponChaosBuff</term><description>2f2eb113da65b6b4fbf69e35c90afe02</description></item>
    /// <item><term>MarksmansAidArrowsQuiverBuff</term><description>df458d92915bc914ba06b5d27d634a39</description></item>
    /// <item><term>WeaponOfDeathBuff</term><description>a8c1e364f631f8a46b8ef23a5528c806</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="enchantmentBlueprint">
    /// <para>
    /// Blueprint of type BlueprintItemEnchantment. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder AddBuffEnchantWornItem(
        bool? allWeapons = null,
        Blueprint<BlueprintItemEnchantmentReference>? enchantmentBlueprint = null,
        EquipSlotBase.SlotType? slot = null)
    {
      var component = new BuffEnchantWornItem();
      component.AllWeapons = allWeapons ?? component.AllWeapons;
      component.m_EnchantmentBlueprint = enchantmentBlueprint?.Reference ?? component.m_EnchantmentBlueprint;
      if (component.m_EnchantmentBlueprint is null)
      {
        component.m_EnchantmentBlueprint = BlueprintTool.GetRef<BlueprintItemEnchantmentReference>(null);
      }
      component.Slot = slot ?? component.Slot;
      return AddComponent(component);
    }

    /// <summary>
    /// Adds <see cref="DropLootAndDestroyOnDeactivate"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>DismemberedUnitBuff</term><description>c98d765d063f57a49a03f13d4f697c33</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddDropLootAndDestroyOnDeactivate(
        IDisposable? coroutine = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new DropLootAndDestroyOnDeactivate();
      Validate(coroutine);
      component.m_Coroutine = coroutine ?? component.m_Coroutine;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="RemoveBuffIfPartyNotInCombat"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AloneInTheDarkBuffCooldown</term><description>9555466f9a8e46b3a4c1459fe0c858c1</description></item>
    /// <item><term>DisarmMainHandBuff</term><description>f7db19748af8b69469073485a65f37cf</description></item>
    /// <item><term>ShiftersRushBuff</term><description>c3365d5a75294b9b879c587668620bd4</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddRemoveBuffIfPartyNotInCombat(
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new RemoveBuffIfPartyNotInCombat();
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="SetMagusFeatureActive"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>SpellCombatBuff</term><description>91e4b45ab5f29574aa1fb41da4bbdcf2</description></item>
    /// <item><term>SpellStrikeBuff</term><description>06e0c9887eb1724409977dac7168bfd7</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddSetMagusFeatureActive(
        SetMagusFeatureActive.FeatureType? feature = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new SetMagusFeatureActive();
      component.m_Feature = feature ?? component.m_Feature;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="ShifterGrabInitiatorBuff"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>BearGrappledInitiatorBuff</term><description>0b2215c8c7d34554a53f970310ac3f35</description></item>
    /// <item><term>ShamblingMoundGrappledInitiatorBuff</term><description>e6bf1a4533604de698b634992d4894c8</description></item>
    /// <item><term>TigerGrappledInitiatorBuff</term><description>652a71aaa0c3492db4ee5b006dfc18fb</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddShifterGrabInitiatorBuff(
        int? attackRollBonus = null,
        int? dexterityBonus = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new ShifterGrabInitiatorBuff();
      component.m_AttackRollBonus = attackRollBonus ?? component.m_AttackRollBonus;
      component.m_DexterityBonus = dexterityBonus ?? component.m_DexterityBonus;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="ShifterGrabTargetBuff"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>BearGrappledTargetBuff</term><description>88be6cbfaf534e009c501e1d2ef3c1f6</description></item>
    /// <item><term>ShamblingMoundGrappledTargetBuff</term><description>2b5743ae1c3e478ab99defebcc881019</description></item>
    /// <item><term>TigerGrappledTargetBuff</term><description>a55e4d7febc3488cbb087c632f83fc52</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddShifterGrabTargetBuff(
        int? attackRollBonus = null,
        int? dexterityBonus = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        int? pinnedACBonus = null)
    {
      var component = new ShifterGrabTargetBuff();
      component.m_AttackRollBonus = attackRollBonus ?? component.m_AttackRollBonus;
      component.m_DexterityBonus = dexterityBonus ?? component.m_DexterityBonus;
      component.m_PinnedACBonus = pinnedACBonus ?? component.m_PinnedACBonus;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="SuppressBuffInSafeZone"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>ShifterWildShapeGriffonBuff</term><description>e76d475eb1f1470e9950a5fee99ddb40</description></item>
    /// <item><term>ShifterWildShapeGriffonDemonBuff14</term><description>431ca9188d6f401f9f8df8079c526e59</description></item>
    /// <item><term>ShifterWildShapeGriffonGodBuff9</term><description>d8b979bf19554b85bbed05e6369c0f63</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddSuppressBuffInSafeZone(
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new SuppressBuffInSafeZone();
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="UniqueBuff"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AllIsDarknessSmiteEvilBuff</term><description>c09d87fb8a5742499d6b820a0e700504</description></item>
    /// <item><term>ProfaneAscensionCharismaBuff1</term><description>503131ef5904487c86a4dbe51b84b66c</description></item>
    /// <item><term>ZeorisDaggerRing_GoverningBuff</term><description>e248e5ef1ae04d559d5fe82ef719ee47</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddUniqueBuff(
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new UniqueBuff();
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="AddMaskOfRazmiry"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>RazmiryMaskBuff</term><description>29c573b30274452baba4b9f0be987959</description></item>
    /// <item><term>RazmiryMaskBuffGold</term><description>a3d5452afb1041b1a2637c63bf405ff1</description></item>
    /// <item><term>RazmiryMaskBuffSilver</term><description>3356e7e835ed45dfa96d777d39493a8a</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="item">
    /// <para>
    /// Blueprint of type BlueprintItemEquipmentGlasses. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddMaskOfRazmiry(
        Blueprint<BlueprintItemEquipmentGlassesReference>? item = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new AddMaskOfRazmiry();
      component.m_Item = item?.Reference ?? component.m_Item;
      if (component.m_Item is null)
      {
        component.m_Item = BlueprintTool.GetRef<BlueprintItemEquipmentGlassesReference>(null);
      }
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="AddKineticistBlade"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>BladeboundBlackBladeBuffLeft</term><description>79582509d2414ab1b5ed4b75464d501e</description></item>
    /// <item><term>KineticBladeIceBlastBuff</term><description>9e7a7d7e8334a5748a8834b0116cf6c4</description></item>
    /// <item><term>LivingGrimoireHolyBookBuffSecondary</term><description>0688ae60216d4356b46b8a71338b7b88</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="blade">
    /// <para>
    /// Blueprint of type BlueprintItemWeapon. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    /// <param name="useSecondaryHandInstead">
    /// <para>
    /// Tooltip: Обычно используем правую руку, можем использовать левую вместо этого.
    /// </para>
    /// </param>
    public TBuilder AddKineticistBlade(
        Blueprint<BlueprintItemWeaponReference>? blade = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        bool? useSecondaryHandInstead = null)
    {
      var component = new AddKineticistBlade();
      component.m_Blade = blade?.Reference ?? component.m_Blade;
      if (component.m_Blade is null)
      {
        component.m_Blade = BlueprintTool.GetRef<BlueprintItemWeaponReference>(null);
      }
      component.UseSecondaryHandInstead = useSecondaryHandInstead ?? component.UseSecondaryHandInstead;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="Polymorph"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>Anevia_DressPolymorph</term><description>6267b23ce31a4ad8b1b3557826671708</description></item>
    /// <item><term>MidnightFane_HuskPolymorphBuff_3</term><description>34f2ec90458a4f1582199a52168b19d9</description></item>
    /// <item><term>YozzPolymorfBuff</term><description>ed4e29772921bc84098f1a9a1dcc3ddb</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="additionalLimbs">
    /// <para>
    /// Blueprint of type BlueprintItemWeapon. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    /// <param name="allowDamageTransfer">
    /// <para>
    /// InfoBox: If checked some components can partially transfer damage characteristics from special weapons to the natural weapons of the polymorph.  E.g. component &amp;apos;PolymorphDamageTransfer&amp;apos; used for ShifterClawBuffLevelNN will take some characteristics of the claws and apply them to attacks of the weapons in the SecondaryAdditionalLimbs slots.
    /// </para>
    /// </param>
    /// <param name="facts">
    /// <para>
    /// Blueprint of type BlueprintUnitFact. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    /// <param name="mainHand">
    /// <para>
    /// Blueprint of type BlueprintItemWeapon. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    /// <param name="offHand">
    /// <para>
    /// Blueprint of type BlueprintItemWeapon. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    /// <param name="portrait">
    /// <para>
    /// Blueprint of type BlueprintPortrait. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    /// <param name="prefab">
    /// You can pass in the animation using a UnitViewLink or it's AssetId.
    /// </param>
    /// <param name="prefabFemale">
    /// You can pass in the animation using a UnitViewLink or it's AssetId.
    /// </param>
    /// <param name="race">
    /// <para>
    /// Blueprint of type BlueprintRace. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    /// <param name="replaceUnitForInspection">
    /// <para>
    /// Blueprint of type BlueprintUnit. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    /// <param name="secondaryAdditionalLimbs">
    /// <para>
    /// Blueprint of type BlueprintItemWeapon. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    /// <param name="useSizeAsBaseForDamage">
    /// <para>
    /// InfoBox: If checked, the Size value will be used as base size instead of the &amp;apos;Medium&amp;apos; size.
    /// </para>
    /// </param>
    public TBuilder AddPolymorph(
        List<Blueprint<BlueprintItemWeaponReference>>? additionalLimbs = null,
        bool? allowDamageTransfer = null,
        int? constitutionBonus = null,
        int? dexterityBonus = null,
        Polymorph.VisualTransitionSettings? enterTransition = null,
        Polymorph.VisualTransitionSettings? exitTransition = null,
        List<Blueprint<BlueprintUnitFactReference>>? facts = null,
        bool? keepSlots = null,
        Blueprint<BlueprintItemWeaponReference>? mainHand = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        int? naturalArmor = null,
        Blueprint<BlueprintItemWeaponReference>? offHand = null,
        Blueprint<BlueprintPortraitReference>? portrait = null,
        AssetLink<UnitViewLink>? prefab = null,
        AssetLink<UnitViewLink>? prefabFemale = null,
        Blueprint<BlueprintRaceReference>? race = null,
        Blueprint<BlueprintUnitReference>? replaceUnitForInspection = null,
        List<Blueprint<BlueprintItemWeaponReference>>? secondaryAdditionalLimbs = null,
        bool? silentCaster = null,
        Size? size = null,
        SpecialDollType? specialDollType = null,
        int? strengthBonus = null,
        PolymorphTransitionSettings? transitionExternal = null,
        bool? useSizeAsBaseForDamage = null)
    {
      var component = new Polymorph();
      component.m_AdditionalLimbs = additionalLimbs?.Select(bp => bp.Reference)?.ToArray() ?? component.m_AdditionalLimbs;
      if (component.m_AdditionalLimbs is null)
      {
        component.m_AdditionalLimbs = new BlueprintItemWeaponReference[0];
      }
      component.AllowDamageTransfer = allowDamageTransfer ?? component.AllowDamageTransfer;
      component.ConstitutionBonus = constitutionBonus ?? component.ConstitutionBonus;
      component.DexterityBonus = dexterityBonus ?? component.DexterityBonus;
      Validate(enterTransition);
      component.m_EnterTransition = enterTransition ?? component.m_EnterTransition;
      Validate(exitTransition);
      component.m_ExitTransition = exitTransition ?? component.m_ExitTransition;
      component.m_Facts = facts?.Select(bp => bp.Reference)?.ToArray() ?? component.m_Facts;
      if (component.m_Facts is null)
      {
        component.m_Facts = new BlueprintUnitFactReference[0];
      }
      component.m_KeepSlots = keepSlots ?? component.m_KeepSlots;
      component.m_MainHand = mainHand?.Reference ?? component.m_MainHand;
      if (component.m_MainHand is null)
      {
        component.m_MainHand = BlueprintTool.GetRef<BlueprintItemWeaponReference>(null);
      }
      component.NaturalArmor = naturalArmor ?? component.NaturalArmor;
      component.m_OffHand = offHand?.Reference ?? component.m_OffHand;
      if (component.m_OffHand is null)
      {
        component.m_OffHand = BlueprintTool.GetRef<BlueprintItemWeaponReference>(null);
      }
      component.m_Portrait = portrait?.Reference ?? component.m_Portrait;
      if (component.m_Portrait is null)
      {
        component.m_Portrait = BlueprintTool.GetRef<BlueprintPortraitReference>(null);
      }
      component.m_Prefab = prefab?.Get() ?? component.m_Prefab;
      component.m_PrefabFemale = prefabFemale?.Get() ?? component.m_PrefabFemale;
      component.m_Race = race?.Reference ?? component.m_Race;
      if (component.m_Race is null)
      {
        component.m_Race = BlueprintTool.GetRef<BlueprintRaceReference>(null);
      }
      component.m_ReplaceUnitForInspection = replaceUnitForInspection?.Reference ?? component.m_ReplaceUnitForInspection;
      if (component.m_ReplaceUnitForInspection is null)
      {
        component.m_ReplaceUnitForInspection = BlueprintTool.GetRef<BlueprintUnitReference>(null);
      }
      component.m_SecondaryAdditionalLimbs = secondaryAdditionalLimbs?.Select(bp => bp.Reference)?.ToArray() ?? component.m_SecondaryAdditionalLimbs;
      if (component.m_SecondaryAdditionalLimbs is null)
      {
        component.m_SecondaryAdditionalLimbs = new BlueprintItemWeaponReference[0];
      }
      component.m_SilentCaster = silentCaster ?? component.m_SilentCaster;
      component.Size = size ?? component.Size;
      component.m_SpecialDollType = specialDollType ?? component.m_SpecialDollType;
      component.StrengthBonus = strengthBonus ?? component.StrengthBonus;
      Validate(transitionExternal);
      component.m_TransitionExternal = transitionExternal ?? component.m_TransitionExternal;
      component.UseSizeAsBaseForDamage = useSizeAsBaseForDamage ?? component.UseSizeAsBaseForDamage;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="PolymorphBonuses"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AnimalAspectGorillaBuff</term><description>2b0b1321fdc53df4dabae1cbf33d46f4</description></item>
    /// <item><term>DLC5_ChaoticTransformationAspecRaptorBuff</term><description>02f51e366d8e4706934a8d8618d4417a</description></item>
    /// <item><term>IronBodyBuff</term><description>2eabea6a1f9a58246a822f207e8ca79e</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddPolymorphBonuses(
        int? masterShifterBonus = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new PolymorphBonuses();
      component.masterShifterBonus = masterShifterBonus ?? component.masterShifterBonus;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="RemoveBuffOnLoad"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AllIsDarknessSmiteEvilBuff</term><description>c09d87fb8a5742499d6b820a0e700504</description></item>
    /// <item><term>DLC3_BrokenTricksterFlowerBuff</term><description>bfe6e5f25a8d43aeae84c416db984ac1</description></item>
    /// <item><term>SmiteEvilBuff</term><description>b6570b8cbb32eaf4ca8255d0ec3310b0</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddRemoveBuffOnLoad(
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        bool? onlyFromParty = null)
    {
      var component = new RemoveBuffOnLoad();
      component.OnlyFromParty = onlyFromParty ?? component.OnlyFromParty;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="RemoveBuffOnTurnOn"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>FadeInOut</term><description>9c9da5cde5e7e5b488c7d48e86b1d99f</description></item>
    /// <item><term>Galfrey_AfterCouncilPolymorph</term><description>727d5a386464485ead4b2919b4003b1e</description></item>
    /// <item><term>NPC_Switch2Neutral</term><description>a121ed5d673eaa94880d0b38a72787ef</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddRemoveBuffOnTurnOn(
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        bool? onlyFromParty = null)
    {
      var component = new RemoveBuffOnTurnOn();
      component.OnlyFromParty = onlyFromParty ?? component.OnlyFromParty;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="AddAreaEffect"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AeonAoOGazeBaseBuff</term><description>da22fac7ee174766a1d924749245b8e9</description></item>
    /// <item><term>GloryDomainGreaterBuffSeparatist</term><description>8a61fe74740745a390aa9ce38fde04a9</description></item>
    /// <item><term>ZeorisDaggerRing_BetrayalAreaBuff</term><description>b2b739c6e18b457d9ba30ab389b0520f</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="areaEffect">
    /// <para>
    /// Blueprint of type BlueprintAbilityAreaEffect. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddAreaEffect(
        Blueprint<BlueprintAbilityAreaEffectReference>? areaEffect = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new AddAreaEffect();
      component.m_AreaEffect = areaEffect?.Reference ?? component.m_AreaEffect;
      if (component.m_AreaEffect is null)
      {
        component.m_AreaEffect = BlueprintTool.GetRef<BlueprintAbilityAreaEffectReference>(null);
      }
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="AddAttackBonus"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <para>
    /// ComponentName: Buffs/Attack bonus
    /// </para>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>DLC3_BesmaraPirateBaseBuff</term><description>c2ea5f0cbdd640af9f24a1b63a2bfb6c</description></item>
    /// <item><term>KnightOfTheWallDefensiveChallengeBuff</term><description>d064c2b40f9b78240a1527bead977df3</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddAttackBonus(
        int? bonus = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new AddAttackBonus();
      component.Bonus = bonus ?? component.Bonus;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="AddCheatDamageBonus"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <para>
    /// ComponentName: Buffs/Damage bonus
    /// </para>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>CheatEmpowerBuff</term><description>9da73e0f62054254d835013c46f3a27a</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddCheatDamageBonus(
        int? bonus = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new AddCheatDamageBonus();
      component.Bonus = bonus ?? component.Bonus;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="AddDispelMagicFailedTrigger"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>SoulsCloakCurseBuff</term><description>40f948d8e5ee2534eb3d701f256f96b5</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddDispelMagicFailedTrigger(
        ActionsBuilder? actionOnCaster = null,
        ActionsBuilder? actionOnOwner = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new AddDispelMagicFailedTrigger();
      component.ActionOnCaster = actionOnCaster?.Build() ?? component.ActionOnCaster;
      if (component.ActionOnCaster is null)
      {
        component.ActionOnCaster = Utils.Constants.Empty.Actions;
      }
      component.ActionOnOwner = actionOnOwner?.Build() ?? component.ActionOnOwner;
      if (component.ActionOnOwner is null)
      {
        component.ActionOnOwner = Utils.Constants.Empty.Actions;
      }
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="AddEffectContextFastHealing"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <para>
    /// ComponentName: Buffs/AddEffect/FastHealing
    /// </para>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>FlameOfLifeEffectBuff</term><description>d79ca3a14a6d46e4987aa2127dafefe3</description></item>
    /// <item><term>MonsterMythicFeature6GoodBuff</term><description>46ec10f8db674998a0dd7a9b96cdd2f3</description></item>
    /// <item><term>SwordofValorCosmeticBuff</term><description>e68e0bedcfd3410798f7513a54e71b75</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddEffectContextFastHealing(
        ContextValue? bonus = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new AddEffectContextFastHealing();
      component.Bonus = bonus ?? component.Bonus;
      if (component.Bonus is null)
      {
        component.Bonus = ContextValues.Constant(0);
      }
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="AddEffectRegeneration"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <para>
    /// ComponentName: Buffs/AddEffect/Regeneration
    /// </para>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>BrandedTrollRegeneration</term><description>da6269afb82c5a14f86281c4e7ff9a4d</description></item>
    /// <item><term>RegenerationColdIronOrFire5</term><description>da6b266204fe2ac4d89786bf66dbe3a9</description></item>
    /// <item><term>WildLink_MonarchEffectBuff</term><description>814b2b51959705945ad6c5ceb08ffbd4</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddEffectRegeneration(
        bool? cancelByMagicWeapon = null,
        DamageAlignment[]? cancelDamageAlignmentTypes = null,
        DamageEnergyType[]? cancelDamageEnergyTypes = null,
        PhysicalDamageMaterial[]? cancelDamageMaterials = null,
        int? heal = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        bool? unremovable = null)
    {
      var component = new AddEffectRegeneration();
      component.CancelByMagicWeapon = cancelByMagicWeapon ?? component.CancelByMagicWeapon;
      component.CancelDamageAlignmentTypes = cancelDamageAlignmentTypes ?? component.CancelDamageAlignmentTypes;
      if (component.CancelDamageAlignmentTypes is null)
      {
        component.CancelDamageAlignmentTypes = new DamageAlignment[0];
      }
      component.CancelDamageEnergyTypes = cancelDamageEnergyTypes ?? component.CancelDamageEnergyTypes;
      if (component.CancelDamageEnergyTypes is null)
      {
        component.CancelDamageEnergyTypes = new DamageEnergyType[0];
      }
      component.CancelDamageMaterials = cancelDamageMaterials ?? component.CancelDamageMaterials;
      if (component.CancelDamageMaterials is null)
      {
        component.CancelDamageMaterials = new PhysicalDamageMaterial[0];
      }
      component.Heal = heal ?? component.Heal;
      component.Unremovable = unremovable ?? component.Unremovable;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="AddGenericStatBonus"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <para>
    /// ComponentName: Buffs/Generic stat bonus
    /// </para>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AxiomiteMeleeMiniboss_Buff_LegendaryProportions</term><description>acf2b59d0d374711b969c5ea864e9656</description></item>
    /// <item><term>EnlargePersonPrimal8Buff</term><description>ebe86df0472a48be939946e9b859987e</description></item>
    /// <item><term>UnboundRageBuff</term><description>303c52f8ca064d558f1c47ba354db006</description></item>
    /// </list>
    /// </remarks>
    public TBuilder AddGenericStatBonus(
        ModifierDescriptor? descriptor = null,
        StatType? stat = null,
        int? value = null)
    {
      var component = new AddGenericStatBonus();
      component.Descriptor = descriptor ?? component.Descriptor;
      component.Stat = stat ?? component.Stat;
      component.Value = value ?? component.Value;
      return AddComponent(component);
    }

    /// <summary>
    /// Adds <see cref="AddMirrorImage"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AnomalyTemplateDefensive_ImagesOfChaosEffectBuff</term><description>ae6e6c03a29d44df9bed230e940af75c</description></item>
    /// <item><term>MirrorImageBuff</term><description>98dc7e7cc6ef59f4abe20c65708ac623</description></item>
    /// <item><term>TricksterFirstAscensionBuff</term><description>b585708811497fc49836fc9112ff1732</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddMirrorImage(
        ContextDiceValue? count = null,
        int? maxCount = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new AddMirrorImage();
      component.Count = count ?? component.Count;
      if (component.Count is null)
      {
        component.Count = Utils.Constants.Empty.DiceValue;
      }
      component.MaxCount = maxCount ?? component.MaxCount;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="AddSpellSchool"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>DisplacementBuff</term><description>00402bae4442a854081264e498e7a833</description></item>
    /// <item><term>IceSubdomainGreaterBuffSeparatist</term><description>95ec6910ea11429b9138cf55e15c6893</description></item>
    /// <item><term>MirrorImageBuff</term><description>98dc7e7cc6ef59f4abe20c65708ac623</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddSpellSchool(
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        SpellSchool? school = null)
    {
      var component = new AddSpellSchool();
      component.School = school ?? component.School;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="FakeDeathAnimationState"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>FakeDeath</term><description>c970916dd6ed4796aa35fcdc12dacb0a</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddFakeDeathAnimationState(
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new FakeDeathAnimationState();
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="IsPositiveEffect"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AuraOfGreaterCourageBuff</term><description>ff183ce55a2896e43bb2dd9f5d989119</description></item>
    /// <item><term>MaskOfNothingBuff</term><description>7543a4b16164467a839f7ec16866fb10</description></item>
    /// <item><term>WildGazeImmunity</term><description>2e64086ebcd066c4b8d1e46c00c8636f</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddIsPositiveEffect(
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new IsPositiveEffect();
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="NegativeLevelComponent"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>ChainedDarkness_Buff_NegativeLevels</term><description>87b7748c1dda4d61b6f6ad82fab50d2f</description></item>
    /// <item><term>MongrelsBlessingBuff</term><description>c5989f96b6184573988a305b4220b9b5</description></item>
    /// <item><term>NegativeLevelsBuff</term><description>b02b6b9221241394db720ca004ea9194</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddNegativeLevelComponent(
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new NegativeLevelComponent();
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="NotDispelable"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>ArueshalaeImmortalityBuff</term><description>7ad9d9982302e2244a7dd73fee6c381b</description></item>
    /// <item><term>ShifterWildShapeGriffonDemonBuff</term><description>6236b745b60a4a578c435c861df393f4</description></item>
    /// <item><term>ShifterWildShapeGriffonDemonBuff9</term><description>7d4798e5fe5f4a349b56686340008824</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddNotDispelable(
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new NotDispelable();
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="RemoveBuffIfCasterIsMissing"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AirElementalInWhirlwind</term><description>8b1b723a20f644c469b99bd541a13a3b</description></item>
    /// <item><term>GriffonGrappledInitiatorBuff</term><description>426228edb7e84943bd1180edf57ecaf9</description></item>
    /// <item><term>WitchHexDeathCurseBuff2</term><description>5e6aeb6852a77b3449b37a4bdb9f7bb4</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddRemoveBuffIfCasterIsMissing(
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        bool? removeOnCasterDeath = null)
    {
      var component = new RemoveBuffIfCasterIsMissing();
      component.RemoveOnCasterDeath = removeOnCasterDeath ?? component.RemoveOnCasterDeath;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="RemoveWhenCombatEnded"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AloneInTheDarkBuffCooldown</term><description>9555466f9a8e46b3a4c1459fe0c858c1</description></item>
    /// <item><term>HideousLaughterBuff</term><description>4b1f07a71a982824988d7f48cd49f3f8</description></item>
    /// <item><term>VinetrapEntangledBuff</term><description>231a622f767e8ed4e9b3e435265a3e99</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddRemoveWhenCombatEnded(
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new RemoveWhenCombatEnded();
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="ResurrectionLogic"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>DLC4_ResurrectionBhogaSwarm</term><description>73e2514b871542ce8f08e40ddf479cd9</description></item>
    /// <item><term>ResurrectionBuff</term><description>12f2f2cf326dfd743b2cce5b14e99b3c</description></item>
    /// <item><term>SongOfTheFallenResurrectionBuffOwnPlace</term><description>a9f029e2495145d9934423b70d8b1f2d</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="firstFx">
    /// You can pass in the animation using a GameObject or it's AssetId.
    /// </param>
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    /// <param name="secondFx">
    /// You can pass in the animation using a GameObject or it's AssetId.
    /// </param>
    /// <param name="shouldRemoveBuff">
    /// <para>
    /// InfoBox: If false buff will be remove according to common buff logic. If true will be removed after fx applied
    /// </para>
    /// </param>
    /// <param name="spawnNearMainCharacter">
    /// <para>
    /// InfoBox: Not change value as &amp;apos;false&amp;apos; when has targets allies!
    /// </para>
    /// </param>
    public TBuilder AddResurrectionLogic(
        Asset<GameObject>? firstFx = null,
        float? firstFxDelay = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        bool? offsetPosition = null,
        Asset<GameObject>? secondFx = null,
        float? secondFxDelay = null,
        bool? shouldRemoveBuff = null,
        bool? spawnNearMainCharacter = null)
    {
      var component = new ResurrectionLogic();
      component.FirstFx = firstFx?.Get() ?? component.FirstFx;
      component.FirstFxDelay = firstFxDelay ?? component.FirstFxDelay;
      component.OffsetPosition = offsetPosition ?? component.OffsetPosition;
      component.SecondFx = secondFx?.Get() ?? component.SecondFx;
      component.SecondFxDelay = secondFxDelay ?? component.SecondFxDelay;
      component.ShouldRemoveBuff = shouldRemoveBuff ?? component.ShouldRemoveBuff;
      component.SpawnNearMainCharacter = spawnNearMainCharacter ?? component.SpawnNearMainCharacter;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="SetBuffOnsetDelay"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>Archpriest_PossessionBuff_ShadowBalorEncounter</term><description>4fc454d17bbc41e7aac430dd570e61c6</description></item>
    /// <item><term>Archpriest_PossessionBuff_ShadowBalorEncounter_Target</term><description>2e73650948d3419b82c74da67030c67e</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddSetBuffOnsetDelay(
        ContextDurationValue? delay = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        ActionsBuilder? onStart = null)
    {
      var component = new SetBuffOnsetDelay();
      Validate(delay);
      component.Delay = delay ?? component.Delay;
      component.OnStart = onStart?.Build() ?? component.OnStart;
      if (component.OnStart is null)
      {
        component.OnStart = Utils.Constants.Empty.Actions;
      }
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="SpecialAnimationState"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <para>
    /// ComponentName: Buffs/Special/AnimationState
    /// </para>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AirElementalInWhirlwind</term><description>8b1b723a20f644c469b99bd541a13a3b</description></item>
    /// <item><term>NightcrawlerBurrowedBuff</term><description>c568b045991644c89c58667c6a17180d</description></item>
    /// <item><term>WyvernInFlight</term><description>ad06fa795a9e7124a88878446c675aaa</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddSpecialAnimationState(
        UnitAnimationActionBuffState? animation = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new SpecialAnimationState();
      Validate(animation);
      component.Animation = animation ?? component.Animation;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="SummonedUnitBuff"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <para>
    /// ComponentName: Buffs/Special/Summoned unit
    /// </para>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>CR12_NabasuAdvancedSummoned</term><description>a1351a09365f46c4afb71e710eec328b</description></item>
    /// <item><term>SummonedUnitBuff</term><description>8728e884eeaa8b047be04197ecf1a0e4</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddSummonedUnitBuff(
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new SummonedUnitBuff();
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="WeaponAttackTypeDamageBonus"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <para>
    /// ComponentName: Buffs/Damage bonus
    /// </para>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>ArmyStandartRageBuff</term><description>77c8d5b837c04fa0a7b44bb7592aee56</description></item>
    /// <item><term>DLC3_SicknessCannibalBuff</term><description>7f528559113d4d58bc255da154e24bd6</description></item>
    /// <item><term>WarDomainBaseBuffSeparatist</term><description>ed756340f71a4022b4031175a39cec2e</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="attackBonus">
    /// <para>
    /// InfoBox: It&amp;apos;s actually damage bonus
    /// </para>
    /// </param>
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddWeaponAttackTypeDamageBonus(
        int? attackBonus = null,
        ModifierDescriptor? descriptor = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        WeaponRangeType? type = null,
        ContextValue? value = null)
    {
      var component = new WeaponAttackTypeDamageBonus();
      component.AttackBonus = attackBonus ?? component.AttackBonus;
      component.Descriptor = descriptor ?? component.Descriptor;
      component.Type = type ?? component.Type;
      component.Value = value ?? component.Value;
      if (component.Value is null)
      {
        component.Value = ContextValues.Constant(0);
      }
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="ActivatableAbilitySetItem"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>ShifterAspectChimeraBearBuff</term><description>993d1b4af8be4facbc3b33b0edda6f15</description></item>
    /// <item><term>ShifterAspectChimeraLizardBuff</term><description>dc3f3ec0246b432f8551cedec87bc00a</description></item>
    /// <item><term>ShifterAspectChimeraWolverineBuff</term><description>b6cfc6cc443c40318062490ff20cefb7</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="activatableAbility">
    /// <para>
    /// Blueprint of type BlueprintActivatableAbility. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddActivatableAbilitySetItem(
        Blueprint<BlueprintActivatableAbilityReference>? activatableAbility = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        ActivatableAbilitySetId? setId = null)
    {
      var component = new ActivatableAbilitySetItem();
      component.m_ActivatableAbility = activatableAbility?.Reference ?? component.m_ActivatableAbility;
      if (component.m_ActivatableAbility is null)
      {
        component.m_ActivatableAbility = BlueprintTool.GetRef<BlueprintActivatableAbilityReference>(null);
      }
      component.m_SetId = setId ?? component.m_SetId;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="ActivatableAbilitySetSwitch"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>ShifterChimeraAspectBuff</term><description>bbf7614374ae4e3da9e284130473a89e</description></item>
    /// <item><term>ShifterChimeraAspectBuffFinal</term><description>5f9990acdfbc4331a5d618e1962eb304</description></item>
    /// <item><term>ShifterChimeraAspectBuffGreater</term><description>7eba1cd350f94617b949641de9766446</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddActivatableAbilitySetSwitch(
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        ActivatableAbilitySetId? setId = null)
    {
      var component = new ActivatableAbilitySetSwitch();
      component.m_SetId = setId ?? component.m_SetId;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="ShiftersFuryItemBuff"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>ShifterFuryBuff</term><description>621bcb0994d74dd09db6931e8f53cc91</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddShiftersFuryItemBuff(
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new ShiftersFuryItemBuff();
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="AdditionalDiceForWeapon"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>BackgroundAlkenstarAlchemist</term><description>f51af2d4fa3358844879cbc5ee0f1073</description></item>
    /// <item><term>ShifterAspectExtraFourSpikes</term><description>1a2dcae8717f44439497be99a49a16f1</description></item>
    /// <item><term>ShifterAspectExtraTwoSpikes</term><description>13fc0a54e43c4757be4722665b5a2c3d</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    /// <param name="useWeaponBlueprintFilter">
    /// <para>
    /// InfoBox: Filters:  the component is applied if no filters enabled or the weapon fits to any of filter lists.
    /// </para>
    /// </param>
    /// <param name="weapons">
    /// <para>
    /// Blueprint of type BlueprintItemWeapon. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    /// <param name="weaponTypes">
    /// <para>
    /// Blueprint of type BlueprintWeaponType. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder AdditionalDiceForWeapon(
        DiceFormula? additionalDamageFormula = null,
        int? diceMultiplier = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        bool? useCustomAdditionalDamageFormula = null,
        bool? useWeaponBlueprintFilter = null,
        bool? useWeaponCategoryFilter = null,
        bool? useWeaponGroupFilter = null,
        bool? useWeaponTypeFilter = null,
        List<WeaponCategory>? weaponCategories = null,
        List<WeaponFighterGroup>? weaponGroups = null,
        List<Blueprint<BlueprintItemWeaponReference>>? weapons = null,
        List<Blueprint<BlueprintWeaponTypeReference>>? weaponTypes = null)
    {
      var component = new AdditionalDiceForWeapon();
      component.m_AdditionalDamageFormula = additionalDamageFormula ?? component.m_AdditionalDamageFormula;
      component.m_DiceMultiplier = diceMultiplier ?? component.m_DiceMultiplier;
      component.m_UseCustomAdditionalDamageFormula = useCustomAdditionalDamageFormula ?? component.m_UseCustomAdditionalDamageFormula;
      component.m_UseWeaponBlueprintFilter = useWeaponBlueprintFilter ?? component.m_UseWeaponBlueprintFilter;
      component.m_UseWeaponCategoryFilter = useWeaponCategoryFilter ?? component.m_UseWeaponCategoryFilter;
      component.m_UseWeaponGroupFilter = useWeaponGroupFilter ?? component.m_UseWeaponGroupFilter;
      component.m_UseWeaponTypeFilter = useWeaponTypeFilter ?? component.m_UseWeaponTypeFilter;
      component.m_WeaponCategories = weaponCategories ?? component.m_WeaponCategories;
      if (component.m_WeaponCategories is null)
      {
        component.m_WeaponCategories = new();
      }
      component.m_WeaponGroups = weaponGroups ?? component.m_WeaponGroups;
      if (component.m_WeaponGroups is null)
      {
        component.m_WeaponGroups = new();
      }
      component.m_Weapons = weapons?.Select(bp => bp.Reference)?.ToList() ?? component.m_Weapons;
      if (component.m_Weapons is null)
      {
        component.m_Weapons = new();
      }
      component.m_WeaponTypes = weaponTypes?.Select(bp => bp.Reference)?.ToList() ?? component.m_WeaponTypes;
      if (component.m_WeaponTypes is null)
      {
        component.m_WeaponTypes = new();
      }
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="ContextCalculateAbilityParams"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>1_FirstStage_AcidBuff</term><description>6afe27c9a2d64eb890673ff3649dacb3</description></item>
    /// <item><term>DemonPlagueFeature</term><description>096156df0b5aa4f458d35db066b27f35</description></item>
    /// <item><term>Yozz_Feature_AdditionalAttacks</term><description>bcf37abbb0b1485b83059600ed440881</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="customProperty">
    /// <para>
    /// Blueprint of type BlueprintUnitProperty. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddContextCalculateAbilityParams(
        ContextValue? casterLevel = null,
        Blueprint<BlueprintUnitPropertyReference>? customProperty = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        bool? replaceCasterLevel = null,
        bool? replaceSpellLevel = null,
        ContextValue? spellLevel = null,
        StatType? statType = null,
        bool? statTypeFromCustomProperty = null,
        bool? useKineticistMainStat = null)
    {
      var component = new ContextCalculateAbilityParams();
      component.CasterLevel = casterLevel ?? component.CasterLevel;
      if (component.CasterLevel is null)
      {
        component.CasterLevel = ContextValues.Constant(0);
      }
      component.m_CustomProperty = customProperty?.Reference ?? component.m_CustomProperty;
      if (component.m_CustomProperty is null)
      {
        component.m_CustomProperty = BlueprintTool.GetRef<BlueprintUnitPropertyReference>(null);
      }
      component.ReplaceCasterLevel = replaceCasterLevel ?? component.ReplaceCasterLevel;
      component.ReplaceSpellLevel = replaceSpellLevel ?? component.ReplaceSpellLevel;
      component.SpellLevel = spellLevel ?? component.SpellLevel;
      if (component.SpellLevel is null)
      {
        component.SpellLevel = ContextValues.Constant(0);
      }
      component.StatType = statType ?? component.StatType;
      component.StatTypeFromCustomProperty = statTypeFromCustomProperty ?? component.StatTypeFromCustomProperty;
      component.UseKineticistMainStat = useKineticistMainStat ?? component.UseKineticistMainStat;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="ContextCalculateAbilityParamsBasedOnClass"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AirBlastAbility</term><description>31f668b12011e344aa542aa07ab6c8d9</description></item>
    /// <item><term>NereidBeguilingAuraBuff</term><description>ab6181f9447a4d945bdcbe6466c42189</description></item>
    /// <item><term>XantirOnlySwarm_MidnightFaneInThePastFeature</term><description>5131c4b93f314bd4589edf612b4eb600</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="characterClass">
    /// <para>
    /// Blueprint of type BlueprintCharacterClass. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddContextCalculateAbilityParamsBasedOnClass(
        Blueprint<BlueprintCharacterClassReference>? characterClass = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        StatType? statType = null,
        bool? useKineticistMainStat = null)
    {
      var component = new ContextCalculateAbilityParamsBasedOnClass();
      component.m_CharacterClass = characterClass?.Reference ?? component.m_CharacterClass;
      if (component.m_CharacterClass is null)
      {
        component.m_CharacterClass = BlueprintTool.GetRef<BlueprintCharacterClassReference>(null);
      }
      component.StatType = statType ?? component.StatType;
      component.UseKineticistMainStat = useKineticistMainStat ?? component.UseKineticistMainStat;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="ContextCalculateSharedValue"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AbyssalCreatureAcidTemplate</term><description>6e6fda1c8a35069468e7398082cd30f5</description></item>
    /// <item><term>InspireTranquilitySavingThrowBuffMythic</term><description>60b646069fa949d8983b4d74fc55218b</description></item>
    /// <item><term>WrackBloodBlastAbility</term><description>0199d49f59833104198e2c0196235a45</description></item>
    /// </list>
    /// </remarks>
    public TBuilder AddContextCalculateSharedValue(
        double? modifier = null,
        ContextDiceValue? value = null,
        AbilitySharedValue? valueType = null)
    {
      var component = new ContextCalculateSharedValue();
      component.Modifier = modifier ?? component.Modifier;
      component.Value = value ?? component.Value;
      if (component.Value is null)
      {
        component.Value = Utils.Constants.Empty.DiceValue;
      }
      component.ValueType = valueType ?? component.ValueType;
      return AddComponent(component);
    }

    /// <summary>
    /// Adds <see cref="ContextSetAbilityParams"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AbruptForceEnchantment</term><description>c31b3edcf2088a64e80133ebbd6374cb</description></item>
    /// <item><term>HeartOfIcebergEnchantment</term><description>719881e400d980f4da1bf7361c1903db</description></item>
    /// <item><term>ZombieSlashingExplosion</term><description>f6b63adab8b645c8beb9cab170dac9d3</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="casterLevel">
    /// <para>
    /// InfoBox: If set to negative value, will be calculated by default mechanic. Positive or zero value will be set as is (plus bonuses)
    /// </para>
    /// </param>
    /// <param name="concentration">
    /// <para>
    /// InfoBox: If set to negative value, will be calculated by default mechanic. Positive or zero value will be set as is (plus bonuses)
    /// </para>
    /// </param>
    /// <param name="dC">
    /// <para>
    /// InfoBox: If set to negative value, will be calculated by default mechanic. Positive or zero value will be set as is (plus bonuses)
    /// </para>
    /// </param>
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    /// <param name="spellLevel">
    /// <para>
    /// InfoBox: If set to negative value, will be calculated by default mechanic. Positive or zero value will be set as is
    /// </para>
    /// </param>
    public TBuilder AddContextSetAbilityParams(
        bool? add10ToDC = null,
        ContextValue? casterLevel = null,
        ContextValue? concentration = null,
        ContextValue? dC = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        ContextValue? spellLevel = null)
    {
      var component = new ContextSetAbilityParams();
      component.Add10ToDC = add10ToDC ?? component.Add10ToDC;
      component.CasterLevel = casterLevel ?? component.CasterLevel;
      if (component.CasterLevel is null)
      {
        component.CasterLevel = ContextValues.Constant(0);
      }
      component.Concentration = concentration ?? component.Concentration;
      if (component.Concentration is null)
      {
        component.Concentration = ContextValues.Constant(0);
      }
      component.DC = dC ?? component.DC;
      if (component.DC is null)
      {
        component.DC = ContextValues.Constant(0);
      }
      component.SpellLevel = spellLevel ?? component.SpellLevel;
      if (component.SpellLevel is null)
      {
        component.SpellLevel = ContextValues.Constant(0);
      }
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="DuplicateDamageToCaster"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>DLC4_UsedBodyCreature</term><description>7eb5f47230824e89ad17cef3cfae851c</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddDuplicateDamageToCaster(
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new DuplicateDamageToCaster();
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="AbilityDifficultyLimitDC"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>StewardOfTheSkeinGazeBuff</term><description>4f18044ca197eb945b7d1b557dd9b447</description></item>
    /// <item><term>Weird</term><description>870af83be6572594d84d276d7fc583e0</description></item>
    /// <item><term>WildHunt_ScoutCrystalAbility</term><description>c470c62b38db74e4fb6b84b331beda30</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddAbilityDifficultyLimitDC(
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new AbilityDifficultyLimitDC();
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="DamageBonusAgainstTacticalTarget"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>ArmyBuildingCathedralBuff</term><description>e9df77ae53da4993a882bb1d1047a4e8</description></item>
    /// <item><term>ArmyLeadership8DamageToInfantryBuff</term><description>406cc284f5714ff0ab3d6231e0aed94a</description></item>
    /// <item><term>FavoredEnemyLargeBuff</term><description>45f4acbece1c4cf4889aaceb46318ae7</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddDamageBonusAgainstTacticalTarget(
        Kingmaker.UnitLogic.Mechanics.ValueType? _valueType = null,
        int? bonusPercentValue = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        TargetFilter? targetFilter = null,
        ContextValue? value = null)
    {
      var component = new DamageBonusAgainstTacticalTarget();
      component._valueType = _valueType ?? component._valueType;
      component.m_BonusPercentValue = bonusPercentValue ?? component.m_BonusPercentValue;
      Validate(targetFilter);
      component.m_TargetFilter = targetFilter ?? component.m_TargetFilter;
      component.m_Value = value ?? component.m_Value;
      if (component.m_Value is null)
      {
        component.m_Value = ContextValues.Constant(0);
      }
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="ReplaceSquadAbilities"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>ArmyBuildingBreweryBuff</term><description>7e2a4a3c182c4f2483a90e8c6d7e0bd8</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    /// <param name="newAbilities">
    /// <para>
    /// Blueprint of type BlueprintAbility. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder AddReplaceSquadAbilities(
        bool? forOneTurn = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        List<Blueprint<BlueprintAbilityReference>>? newAbilities = null)
    {
      var component = new ReplaceSquadAbilities();
      component.m_ForOneTurn = forOneTurn ?? component.m_ForOneTurn;
      component.m_NewAbilities = newAbilities?.Select(bp => bp.Reference)?.ToList() ?? component.m_NewAbilities;
      if (component.m_NewAbilities is null)
      {
        component.m_NewAbilities = new();
      }
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="TacticalCombatConfusion"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>ArmyConfusedBuff</term><description>1da4d884ccac4c1a89465ea8ad48c7e4</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="aiAttackNearestAction">
    /// <para>
    /// InfoBox: Set action with Can Attack allies flag
    /// </para>
    /// <para>
    /// Blueprint of type BlueprintTacticalCombatAiAction. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    /// <param name="harmSelfAction">
    /// <para>
    /// InfoBox: Owner is target here
    /// </para>
    /// </param>
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddTacticalCombatConfusion(
        Blueprint<BlueprintTacticalCombatAiActionReference>? aiAttackNearestAction = null,
        ActionsBuilder? harmSelfAction = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new TacticalCombatConfusion();
      component.m_AiAttackNearestAction = aiAttackNearestAction?.Reference ?? component.m_AiAttackNearestAction;
      if (component.m_AiAttackNearestAction is null)
      {
        component.m_AiAttackNearestAction = BlueprintTool.GetRef<BlueprintTacticalCombatAiActionReference>(null);
      }
      component.m_HarmSelfAction = harmSelfAction?.Build() ?? component.m_HarmSelfAction;
      if (component.m_HarmSelfAction is null)
      {
        component.m_HarmSelfAction = Utils.Constants.Empty.Actions;
      }
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="TacticalMoraleChanceModifier"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>ArmyBuildingBulletingBoard</term><description>d3fc356cf3ad44129a995b64fbb513ab</description></item>
    /// <item><term>ArmyBuildingTavern</term><description>5b7dae6b75e7483ba1bc10d890a690c7</description></item>
    /// <item><term>Ziforian_feature</term><description>59820030350e40fe86a83d3ca412b221</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    /// <param name="negativeMoraleChancePercentDelta">
    /// <para>
    /// InfoBox: Negative Morale chance formula: Chance = -Morale / NegativeMoraleModifier + NegativeMoraleChance
    /// </para>
    /// </param>
    /// <param name="positiveMoraleChancePercentDelta">
    /// <para>
    /// InfoBox: Positive Morale chance formula: Chance = UnitMorale / PositiveMoraleModifier + PositiveMoraleChance
    /// </para>
    /// </param>
    public TBuilder AddTacticalMoraleChanceModifier(
        bool? changeNegativeMorale = null,
        bool? changePositiveMorale = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        ContextValue? negativeMoraleChancePercentDelta = null,
        ContextValue? positiveMoraleChancePercentDelta = null)
    {
      var component = new TacticalMoraleChanceModifier();
      component.m_ChangeNegativeMorale = changeNegativeMorale ?? component.m_ChangeNegativeMorale;
      component.m_ChangePositiveMorale = changePositiveMorale ?? component.m_ChangePositiveMorale;
      component.m_NegativeMoraleChancePercentDelta = negativeMoraleChancePercentDelta ?? component.m_NegativeMoraleChancePercentDelta;
      if (component.m_NegativeMoraleChancePercentDelta is null)
      {
        component.m_NegativeMoraleChancePercentDelta = ContextValues.Constant(0);
      }
      component.m_PositiveMoraleChancePercentDelta = positiveMoraleChancePercentDelta ?? component.m_PositiveMoraleChancePercentDelta;
      if (component.m_PositiveMoraleChancePercentDelta is null)
      {
        component.m_PositiveMoraleChancePercentDelta = ContextValues.Constant(0);
      }
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="TargetingBlind"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>BlindVictimBuff</term><description>43981a02863a5d34b9e1448d32000fd7</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddTargetingBlind(
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new TargetingBlind();
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="BuffExtraEffects"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <para>
    /// ComponentName: Add extra buff to buff
    /// </para>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AeonBaneFeature</term><description>0b25e8d8b0488c84c9b5714e9ca0a204</description></item>
    /// <item><term>HeartOfEarthShifterFeature</term><description>0b09ce94b5fe48dfa81b9a6f9d55a351</description></item>
    /// <item><term>WreckingBlowsFeature</term><description>5bccc86dd1f187a4a99f092dc054c755</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="checkedBuff">
    /// <para>
    /// Blueprint of type BlueprintBuff. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    /// <param name="checkedBuffList">
    /// <para>
    /// Tooltip: If you need more than 1 buff to check - additional field bc of compatibility issues. First fill in the first field, only then additional!
    /// </para>
    /// <para>
    /// Blueprint of type BlueprintBuff. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    /// <param name="exceptionFact">
    /// <para>
    /// Blueprint of type BlueprintUnitFact. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    /// <param name="extraEffectBuff">
    /// <para>
    /// Blueprint of type BlueprintBuff. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder AddBuffExtraEffects(
        Blueprint<BlueprintBuffReference>? checkedBuff = null,
        List<Blueprint<BlueprintBuffReference>>? checkedBuffList = null,
        Blueprint<BlueprintUnitFactReference>? exceptionFact = null,
        Blueprint<BlueprintBuffReference>? extraEffectBuff = null,
        bool? useBaffContext = null)
    {
      var component = new BuffExtraEffects();
      component.m_CheckedBuff = checkedBuff?.Reference ?? component.m_CheckedBuff;
      if (component.m_CheckedBuff is null)
      {
        component.m_CheckedBuff = BlueprintTool.GetRef<BlueprintBuffReference>(null);
      }
      component.m_CheckedBuffList = checkedBuffList?.Select(bp => bp.Reference)?.ToArray() ?? component.m_CheckedBuffList;
      if (component.m_CheckedBuffList is null)
      {
        component.m_CheckedBuffList = new BlueprintBuffReference[0];
      }
      component.m_ExceptionFact = exceptionFact?.Reference ?? component.m_ExceptionFact;
      if (component.m_ExceptionFact is null)
      {
        component.m_ExceptionFact = BlueprintTool.GetRef<BlueprintUnitFactReference>(null);
      }
      component.m_ExtraEffectBuff = extraEffectBuff?.Reference ?? component.m_ExtraEffectBuff;
      if (component.m_ExtraEffectBuff is null)
      {
        component.m_ExtraEffectBuff = BlueprintTool.GetRef<BlueprintBuffReference>(null);
      }
      component.m_UseBaffContext = useBaffContext ?? component.m_UseBaffContext;
      return AddComponent(component);
    }

    /// <summary>
    /// Adds <see cref="HealResistance"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>DLC3_SicknessHeavyDiseaseBuff</term><description>4a19a78fbde84e03b4547137b11ddc3a</description></item>
    /// <item><term>ShadowMadnessHealDebuff</term><description>824b53ebe4014076ba91ea2b787b7239</description></item>
    /// <item><term>ZonKuthonBuff</term><description>83ee9bf48b4249858df8f8ea5fe6ef06</description></item>
    /// </list>
    /// </remarks>
    public TBuilder AddHealResistance(
        float? resistance = null)
    {
      var component = new HealResistance();
      component.Resistance = resistance ?? component.Resistance;
      return AddComponent(component);
    }

    /// <summary>
    /// Adds <see cref="MetamagicOnNextSpell"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>BattleMagesHeadbandBuff</term><description>2c06b3504c3013e4ba7ea04b1d9201a3</description></item>
    /// <item><term>QuickenedArcanaBuff</term><description>5a62abe6d8de2e24b8834493438b3e23</description></item>
    /// <item><term>UniversalistSchoolReachBuff</term><description>8bc0ae0545e59f14aaef85f064fdc263</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    /// <param name="sourcerousReflex">
    /// <para>
    /// InfoBox: Проверить что заклинание 1ого уровня или на 2 уровня ниже, чем макс. доступный уровень заклинаний
    /// </para>
    /// </param>
    public TBuilder AddMetamagicOnNextSpell(
        bool? doNotRemove = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        Metamagic? metamagic = null,
        bool? sourcerousReflex = null)
    {
      var component = new MetamagicOnNextSpell();
      component.DoNotRemove = doNotRemove ?? component.DoNotRemove;
      component.Metamagic = metamagic ?? component.Metamagic;
      component.SourcerousReflex = sourcerousReflex ?? component.SourcerousReflex;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="MetamagicRodMechanics"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AmberLoveRodBuff</term><description>3123ec8935850514aab8edccf7d8e942</description></item>
    /// <item><term>MetamagicRodLesserMaximizeBuff</term><description>9799c61073256e747bcbbda5a565af8d</description></item>
    /// <item><term>SkeletalFingerRodQuickenNormalBuff</term><description>2e03f85b3e759a743b2cae86b687ba4f</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="abilitiesWhiteList">
    /// <para>
    /// Blueprint of type BlueprintAbility. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    /// <param name="rodAbility">
    /// <para>
    /// Blueprint of type BlueprintActivatableAbility. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder AddMetamagicRodMechanics(
        List<Blueprint<BlueprintAbilityReference>>? abilitiesWhiteList = null,
        bool? forceIgnoreSpellResist = null,
        int? maxSpellLevel = null,
        Metamagic? metamagic = null,
        Blueprint<BlueprintActivatableAbilityReference>? rodAbility = null)
    {
      var component = new MetamagicRodMechanics();
      component.m_AbilitiesWhiteList = abilitiesWhiteList?.Select(bp => bp.Reference)?.ToArray() ?? component.m_AbilitiesWhiteList;
      if (component.m_AbilitiesWhiteList is null)
      {
        component.m_AbilitiesWhiteList = new BlueprintAbilityReference[0];
      }
      component.ForceIgnoreSpellResist = forceIgnoreSpellResist ?? component.ForceIgnoreSpellResist;
      component.MaxSpellLevel = maxSpellLevel ?? component.MaxSpellLevel;
      component.Metamagic = metamagic ?? component.Metamagic;
      component.m_RodAbility = rodAbility?.Reference ?? component.m_RodAbility;
      if (component.m_RodAbility is null)
      {
        component.m_RodAbility = BlueprintTool.GetRef<BlueprintActivatableAbilityReference>(null);
      }
      return AddComponent(component);
    }

    /// <summary>
    /// Adds <see cref="NeutralToFaction"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>Charm</term><description>9dc29118addce3d48ae9b92be953b5b4</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="faction">
    /// <para>
    /// Blueprint of type BlueprintFaction. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddNeutralToFaction(
        Blueprint<BlueprintFactionReference>? faction = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new NeutralToFaction();
      component.m_Faction = faction?.Reference ?? component.m_Faction;
      if (component.m_Faction is null)
      {
        component.m_Faction = BlueprintTool.GetRef<BlueprintFactionReference>(null);
      }
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="SpecificSpellDamageBonus"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>SpellblastBombBuff</term><description>c783f23e678f71542995c01e36540206</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    /// <param name="spell">
    /// <para>
    /// Blueprint of type BlueprintAbility. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder AddSpecificSpellDamageBonus(
        int? bonus = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        List<Blueprint<BlueprintAbilityReference>>? spell = null)
    {
      var component = new SpecificSpellDamageBonus();
      component.Bonus = bonus ?? component.Bonus;
      component.m_Spell = spell?.Select(bp => bp.Reference)?.ToArray() ?? component.m_Spell;
      if (component.m_Spell is null)
      {
        component.m_Spell = new BlueprintAbilityReference[0];
      }
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="WatchYourBack"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>GhostRiderSharedMindsFeature</term><description>bfd44a5ed010428abdeede2453e2272b</description></item>
    /// <item><term>TandemExecutionerWatchOutForTheSpellPetBuff</term><description>499b7a74611442a5a6e1ede222c22398</description></item>
    /// <item><term>TandemExecutionerWatchYourBackPetBuff</term><description>7a5328096ad345459d7145890c6f0267</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="cooldownBuff">
    /// <para>
    /// Blueprint of type BlueprintBuff. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    /// <param name="cooldownRounds">
    /// <para>
    /// InfoBox: Сколько раундов длится кулдаун
    /// </para>
    /// </param>
    /// <param name="failedSaveOwner">
    /// <para>
    /// InfoBox: Какой спас проваливает хозяин. Если Unknown - не работает.
    /// </para>
    /// </param>
    /// <param name="failedSavePet">
    /// <para>
    /// InfoBox: Какой спас проваливает пет. Если Unknown - не работает.
    /// </para>
    /// </param>
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    /// <param name="ownerCanSavePet">
    /// <para>
    /// InfoBox: Если выбрано - хозяин может спасти пета
    /// </para>
    /// </param>
    /// <param name="petCanSaveOwner">
    /// <para>
    /// InfoBox: Если выбрано - пет может спасти хозяина
    /// </para>
    /// </param>
    /// <param name="statCheckOwner">
    /// <para>
    /// InfoBox: Какой стат проверяет хозяин, чтобы спасти пета. Если Unknown - не работает.
    /// </para>
    /// </param>
    /// <param name="statCheckPet">
    /// <para>
    /// InfoBox: Какой стат проверяет пет, чтобы спасти хоязина. Если Unknown - не работает.
    /// </para>
    /// </param>
    /// <param name="triggerByFailedSkillCheck">
    /// <para>
    /// InfoBox: Если выбрано - то провалы спаса триггерят
    /// </para>
    /// </param>
    /// <param name="triggerByHit">
    /// <para>
    /// InfoBox: Если выбрано - то получение урона триггерит
    /// </para>
    /// </param>
    public TBuilder AddWatchYourBack(
        Blueprint<BlueprintBuffReference>? cooldownBuff = null,
        int? cooldownRounds = null,
        FlaggedSavingThrowType? failedSaveOwner = null,
        FlaggedSavingThrowType? failedSavePet = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        bool? ownerCanSavePet = null,
        bool? petCanSaveOwner = null,
        PetType? petType = null,
        StatType? statCheckOwner = null,
        StatType? statCheckPet = null,
        bool? triggerByFailedSkillCheck = null,
        bool? triggerByHit = null)
    {
      var component = new WatchYourBack();
      component.m_CooldownBuff = cooldownBuff?.Reference ?? component.m_CooldownBuff;
      if (component.m_CooldownBuff is null)
      {
        component.m_CooldownBuff = BlueprintTool.GetRef<BlueprintBuffReference>(null);
      }
      component.m_CooldownRounds = cooldownRounds ?? component.m_CooldownRounds;
      component.m_FailedSaveOwner = failedSaveOwner ?? component.m_FailedSaveOwner;
      component.m_FailedSavePet = failedSavePet ?? component.m_FailedSavePet;
      component.m_OwnerCanSavePet = ownerCanSavePet ?? component.m_OwnerCanSavePet;
      component.m_PetCanSaveOwner = petCanSaveOwner ?? component.m_PetCanSaveOwner;
      component.m_PetType = petType ?? component.m_PetType;
      component.m_StatCheckOwner = statCheckOwner ?? component.m_StatCheckOwner;
      component.m_StatCheckPet = statCheckPet ?? component.m_StatCheckPet;
      component.m_TriggerByFailedSkillCheck = triggerByFailedSkillCheck ?? component.m_TriggerByFailedSkillCheck;
      component.m_TriggerByHit = triggerByHit ?? component.m_TriggerByHit;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="ACBonusAgainstCaster"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>DebilitatingInjuryBewilderedEffectBuff</term><description>22b1d98502050cb4cbdb3679ac53115e</description></item>
    /// <item><term>TandemExecutionerPenetratingCascadeDebuff</term><description>e32be57d84a74d68aeb8ba8738d37655</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddACBonusAgainstCaster(
        ModifierDescriptor? descriptor = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        ContextValue? value = null)
    {
      var component = new ACBonusAgainstCaster();
      component.Descriptor = descriptor ?? component.Descriptor;
      component.Value = value ?? component.Value;
      if (component.Value is null)
      {
        component.Value = ContextValues.Constant(0);
      }
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="ACBonusAgainstTarget"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AllIsDarknessSmiteBuff_NoScabbard</term><description>3ee42d04faf9477bb7765c3fcb7f7a27</description></item>
    /// <item><term>ChampionOfTheFaithSmiteBuff</term><description>c362c2d961d28f1438094bac025e06a2</description></item>
    /// <item><term>SmiteEvilBuff_Scabbard</term><description>d0261b79ea01d73418eaf3307352792c</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddACBonusAgainstTarget(
        bool? checkCaster = null,
        bool? checkCasterFriend = null,
        ModifierDescriptor? descriptor = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        ContextValue? value = null)
    {
      var component = new ACBonusAgainstTarget();
      component.CheckCaster = checkCaster ?? component.CheckCaster;
      component.CheckCasterFriend = checkCasterFriend ?? component.CheckCasterFriend;
      component.Descriptor = descriptor ?? component.Descriptor;
      component.Value = value ?? component.Value;
      if (component.Value is null)
      {
        component.Value = ContextValues.Constant(0);
      }
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="AddAdditionalLimbIfHasFact"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>DefensiveStanceBuff</term><description>3dccdf27a8209af478ac71cded18a271</description></item>
    /// <item><term>StonelordDefensiveStanceBuff</term><description>99ab5d010faa4c83b7d41bdd6b1afa83</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="checkedFact">
    /// <para>
    /// Blueprint of type BlueprintFeature. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    /// <param name="weapon">
    /// <para>
    /// Blueprint of type BlueprintItemWeapon. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder AddAdditionalLimbIfHasFact(
        Blueprint<BlueprintFeatureReference>? checkedFact = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        Blueprint<BlueprintItemWeaponReference>? weapon = null)
    {
      var component = new AddAdditionalLimbIfHasFact();
      component.m_CheckedFact = checkedFact?.Reference ?? component.m_CheckedFact;
      if (component.m_CheckedFact is null)
      {
        component.m_CheckedFact = BlueprintTool.GetRef<BlueprintFeatureReference>(null);
      }
      component.m_Weapon = weapon?.Reference ?? component.m_Weapon;
      if (component.m_Weapon is null)
      {
        component.m_Weapon = BlueprintTool.GetRef<BlueprintItemWeaponReference>(null);
      }
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="AddStatBonusAbilityValue"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <para>
    /// ComponentName: Add stat bonus from ability value
    /// </para>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>ArmyDragonPlagueBuff</term><description>5b7d53fbb5e442d785da22e2de073db3</description></item>
    /// <item><term>DLC5_SithhudSeal10Buff</term><description>6e44938e71354ccf80cdb62837c6edba</description></item>
    /// <item><term>ShatterConfidenceBuff</term><description>14225a2e4561bfd46874c9a4a97e7133</description></item>
    /// </list>
    /// </remarks>
    public TBuilder AddStatBonusAbilityValue(
        ModifierDescriptor? descriptor = null,
        StatType? stat = null,
        ContextValue? value = null)
    {
      var component = new AddStatBonusAbilityValue();
      component.Descriptor = descriptor ?? component.Descriptor;
      component.Stat = stat ?? component.Stat;
      component.Value = value ?? component.Value;
      if (component.Value is null)
      {
        component.Value = ContextValues.Constant(0);
      }
      return AddComponent(component);
    }

    /// <summary>
    /// Adds <see cref="AttackBonusAgainstCaster"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>DebilitatingInjuryDisorientedEffectBuff</term><description>1f1e42f8c06d7dc4bb70cc12c73dfb38</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddAttackBonusAgainstCaster(
        ModifierDescriptor? descriptor = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        ContextValue? value = null)
    {
      var component = new AttackBonusAgainstCaster();
      component.Descriptor = descriptor ?? component.Descriptor;
      component.Value = value ?? component.Value;
      if (component.Value is null)
      {
        component.Value = ContextValues.Constant(0);
      }
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="AttackBonusAgainstTarget"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AllIsDarknessSmiteEvilBuff</term><description>c09d87fb8a5742499d6b820a0e700504</description></item>
    /// <item><term>FinalJusticeAbilityBuff</term><description>2e6eaaf0855a46c5abb22c050063dd57</description></item>
    /// <item><term>VanguardAlliesStudyTargetBuff</term><description>261d47a0e2df6cf4fa6f02ec2cfb528a</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddAttackBonusAgainstTarget(
        bool? checkCaster = null,
        bool? checkCasterFriend = null,
        bool? checkRangeType = null,
        ModifierDescriptor? descriptor = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        WeaponRangeType? rangeType = null,
        ContextValue? value = null)
    {
      var component = new AttackBonusAgainstTarget();
      component.CheckCaster = checkCaster ?? component.CheckCaster;
      component.CheckCasterFriend = checkCasterFriend ?? component.CheckCasterFriend;
      component.CheckRangeType = checkRangeType ?? component.CheckRangeType;
      component.Descriptor = descriptor ?? component.Descriptor;
      component.RangeType = rangeType ?? component.RangeType;
      component.Value = value ?? component.Value;
      if (component.Value is null)
      {
        component.Value = ContextValues.Constant(0);
      }
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="BuffInvisibility"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>DLC4_InvisibilityBuff_Cutscene</term><description>55dba144a4c54f2890a8f21f72886330</description></item>
    /// <item><term>OracleRevelationInvisibilityBuff</term><description>a2b527cfac3f87244a133415a7cb5926</description></item>
    /// <item><term>VanishBuff</term><description>e5b7ef8d49215314daaf0404349d42a6</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddBuffInvisibility(
        ContextValue? chance = null,
        bool? dispelWithAChance = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        bool? notDispellAfterOffensiveAction = null,
        int? stealthBonus = null)
    {
      var component = new BuffInvisibility();
      component.Chance = chance ?? component.Chance;
      if (component.Chance is null)
      {
        component.Chance = ContextValues.Constant(0);
      }
      component.DispelWithAChance = dispelWithAChance ?? component.DispelWithAChance;
      component.NotDispellAfterOffensiveAction = notDispellAfterOffensiveAction ?? component.NotDispellAfterOffensiveAction;
      component.m_StealthBonus = stealthBonus ?? component.m_StealthBonus;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="BuffPoisonStatDamage"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <para>
    /// ComponentName: BuffMechanics/Add Random Stat Penalty
    /// </para>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>ApocalypseLocustPoisonBuff</term><description>9857d0c4417c47209dcb0ba64ad14c98</description></item>
    /// <item><term>DrunkenKiSpitVenomBuff</term><description>a4632f1478a0412db423f0c230f36a1e</description></item>
    /// <item><term>WyvernPoisonBuff</term><description>b5d9dc8671f8c9c4dab37f0ba52ab9d1</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="weaknessForPoison">
    /// <para>
    /// Blueprint of type BlueprintBuff. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder AddBuffPoisonStatDamage(
        int? bonus = null,
        ModifierDescriptor? descriptor = null,
        bool? noEffectOnFirstTick = null,
        SavingThrowType? saveType = null,
        StatType? stat = null,
        int? succesfullSaves = null,
        int? ticks = null,
        DiceFormula? value = null,
        Blueprint<BlueprintBuffReference>? weaknessForPoison = null)
    {
      var component = new BuffPoisonStatDamage();
      component.Bonus = bonus ?? component.Bonus;
      component.Descriptor = descriptor ?? component.Descriptor;
      component.NoEffectOnFirstTick = noEffectOnFirstTick ?? component.NoEffectOnFirstTick;
      component.SaveType = saveType ?? component.SaveType;
      component.Stat = stat ?? component.Stat;
      component.SuccesfullSaves = succesfullSaves ?? component.SuccesfullSaves;
      component.Ticks = ticks ?? component.Ticks;
      component.Value = value ?? component.Value;
      component.WeaknessForPoison = weaknessForPoison?.Reference ?? component.WeaknessForPoison;
      if (component.WeaknessForPoison is null)
      {
        component.WeaknessForPoison = BlueprintTool.GetRef<BlueprintBuffReference>(null);
      }
      return AddComponent(component);
    }

    /// <summary>
    /// Adds <see cref="BuffPoisonStatDamageContext"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <para>
    /// ComponentName: BuffMechanics/Add Random Stat Penalty
    /// </para>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AssassinCreatePoisonAbilityConBuffEffect</term><description>6542e025d84501a41b652bcdc57f6901</description></item>
    /// <item><term>AssassinCreatePoisonAbilityDexBuffEffect</term><description>c766f0606ac12e24e8a9fdb8beabc6c2</description></item>
    /// <item><term>AssassinCreatePoisonAbilityStrBuffEffect</term><description>285290cc80941bc4c97461d6f50aaad9</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="weaknessForPoison">
    /// <para>
    /// Blueprint of type BlueprintBuff. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder AddBuffPoisonStatDamageContext(
        ContextValue? bonus = null,
        ModifierDescriptor? descriptor = null,
        bool? noEffectOnFirstTick = null,
        SavingThrowType? saveType = null,
        StatType? stat = null,
        ContextValue? succesfullSaves = null,
        ContextValue? ticks = null,
        ContextDiceValue? value = null,
        Blueprint<BlueprintBuffReference>? weaknessForPoison = null)
    {
      var component = new BuffPoisonStatDamageContext();
      component.Bonus = bonus ?? component.Bonus;
      if (component.Bonus is null)
      {
        component.Bonus = ContextValues.Constant(0);
      }
      component.Descriptor = descriptor ?? component.Descriptor;
      component.NoEffectOnFirstTick = noEffectOnFirstTick ?? component.NoEffectOnFirstTick;
      component.SaveType = saveType ?? component.SaveType;
      component.Stat = stat ?? component.Stat;
      component.SuccesfullSaves = succesfullSaves ?? component.SuccesfullSaves;
      if (component.SuccesfullSaves is null)
      {
        component.SuccesfullSaves = ContextValues.Constant(0);
      }
      component.Ticks = ticks ?? component.Ticks;
      if (component.Ticks is null)
      {
        component.Ticks = ContextValues.Constant(0);
      }
      component.Value = value ?? component.Value;
      if (component.Value is null)
      {
        component.Value = Utils.Constants.Empty.DiceValue;
      }
      component.WeaknessForPoison = weaknessForPoison?.Reference ?? component.WeaknessForPoison;
      if (component.WeaknessForPoison is null)
      {
        component.WeaknessForPoison = BlueprintTool.GetRef<BlueprintBuffReference>(null);
      }
      return AddComponent(component);
    }

    /// <summary>
    /// Adds <see cref="BuffSleeping"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>Sleeping</term><description>5e0cd801bac0e95429bb7e4d1bc61a23</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddBuffSleeping(
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        int? wakeupPerceptionDC = null)
    {
      var component = new BuffSleeping();
      component.WakeupPerceptionDC = wakeupPerceptionDC ?? component.WakeupPerceptionDC;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="ControlledProjectileHolder"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>BoneSpearProjectileBuff</term><description>a99e1f16c3f614b419e7722ae71a7459</description></item>
    /// <item><term>HasControllableProjectileBuff</term><description>0e92c82297202bd4abac2c5a2ce2f9d3</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddControlledProjectileHolder(
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new ControlledProjectileHolder();
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="DamageBonusAgainstTarget"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AllIsDarknessSmiteEvilBuff</term><description>c09d87fb8a5742499d6b820a0e700504</description></item>
    /// <item><term>FinalJusticeAbilityBuff</term><description>2e6eaaf0855a46c5abb22c050063dd57</description></item>
    /// <item><term>VanguardAlliesStudyTargetBuff</term><description>261d47a0e2df6cf4fa6f02ec2cfb528a</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddDamageBonusAgainstTarget(
        bool? applyToSpellDamage = null,
        bool? checkCaster = null,
        bool? checkCasterFriend = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        ContextValue? value = null)
    {
      var component = new DamageBonusAgainstTarget();
      component.ApplyToSpellDamage = applyToSpellDamage ?? component.ApplyToSpellDamage;
      component.CheckCaster = checkCaster ?? component.CheckCaster;
      component.CheckCasterFriend = checkCasterFriend ?? component.CheckCasterFriend;
      component.Value = value ?? component.Value;
      if (component.Value is null)
      {
        component.Value = ContextValues.Constant(0);
      }
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="IgnoreTargetCritImmunity"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>StudentOfWarDeadlyBlowBuff</term><description>7795183a0e72ec14cb2e4d51acc53773</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddIgnoreTargetCritImmunity(
        bool? checkCaster = null,
        bool? checkCasterFriend = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new IgnoreTargetCritImmunity();
      component.CheckCaster = checkCaster ?? component.CheckCaster;
      component.CheckCasterFriend = checkCasterFriend ?? component.CheckCasterFriend;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="IgnoreTargetDR"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AllIsDarknessSmiteEvilBuff</term><description>c09d87fb8a5742499d6b820a0e700504</description></item>
    /// <item><term>FinalJusticeAbilityBuff</term><description>2e6eaaf0855a46c5abb22c050063dd57</description></item>
    /// <item><term>StudentOfWarDeadlyBlowBuff</term><description>7795183a0e72ec14cb2e4d51acc53773</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddIgnoreTargetDR(
        bool? checkCaster = null,
        bool? checkCasterFriend = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new IgnoreTargetDR();
      component.CheckCaster = checkCaster ?? component.CheckCaster;
      component.CheckCasterFriend = checkCasterFriend ?? component.CheckCasterFriend;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="OverrideLocoMotion"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>Anevia_BrokenLeg</term><description>13e59e6d056c3ba4e8b44b9dce3b641a</description></item>
    /// <item><term>DLC5_SithhudTopLocomotion_Buff</term><description>fd32238dba914f8f8e57d90d44247129</description></item>
    /// <item><term>TorchAnimations_Buff</term><description>06d32871142844e5a14d43c6e0ca9bb4</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddOverrideLocoMotion(
        UnitAnimationActionLocoMotion? locoMotion = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new OverrideLocoMotion();
      Validate(locoMotion);
      component.LocoMotion = locoMotion ?? component.LocoMotion;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="RemovedByHeal"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>ArmyBloodLustAuraEnemyBuff</term><description>da30e66cd0144a04ab8275666d34254d</description></item>
    /// <item><term>DebilitatingInjuryDisorientedEffectBuff</term><description>1f1e42f8c06d7dc4bb70cc12c73dfb38</description></item>
    /// <item><term>Gallu_Buff_RainOfBlood</term><description>1abd01485cd76784f8ca078e80132a76</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddRemovedByHeal(
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new RemovedByHeal();
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="HalfOfPairComponent"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>HalfOfPairedPendantBuff</term><description>066229a41ae97d6439fea81ebf141528</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="buff">
    /// <para>
    /// Blueprint of type BlueprintBuff. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddHalfOfPairComponent(
        Blueprint<BlueprintBuffReference>? buff = null,
        int? distanceToActivateInFeet = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        float? sqrDistance = null)
    {
      var component = new HalfOfPairComponent();
      component.m_Buff = buff?.Reference ?? component.m_Buff;
      if (component.m_Buff is null)
      {
        component.m_Buff = BlueprintTool.GetRef<BlueprintBuffReference>(null);
      }
      component.m_DistanceToActivateInFeet = distanceToActivateInFeet ?? component.m_DistanceToActivateInFeet;
      component.m_SqrDistance = sqrDistance ?? component.m_SqrDistance;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    protected override void OnConfigureCompleted()
    {
      base.OnConfigureCompleted();
    
      if (Blueprint.FxOnStart is null)
      {
        Blueprint.FxOnStart = Utils.Constants.Empty.PrefabLink;
      }
      if (Blueprint.FxOnRemove is null)
      {
        Blueprint.FxOnRemove = Utils.Constants.Empty.PrefabLink;
      }
      if (Blueprint.ResourceAssetIds is null)
      {
        Blueprint.ResourceAssetIds = new string[0];
      }
    }
  }
}

//***** AUTO-GENERATED - DO NOT EDIT *****//

using BlueprintCore.Conditions.Builder;
using BlueprintCore.Utils;
using BlueprintCore.Utils.Types;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.Blueprints.Classes.Spells;
using Kingmaker.Blueprints.Facts;
using Kingmaker.Blueprints.Items;
using Kingmaker.ElementsSystem;
using Kingmaker.EntitySystem.Stats;
using Kingmaker.Enums;
using Kingmaker.UnitLogic.Abilities;
using Kingmaker.UnitLogic.Buffs.Blueprints;
using Kingmaker.UnitLogic.Mechanics;
using Kingmaker.UnitLogic.Mechanics.Conditions;
using Kingmaker.Utility;
using Kingmaker.View.Animation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlueprintCore.Conditions.Builder.ContextEx
{
  /// <summary>
  /// Extension to <see cref="ConditionsBuilder"/> for most <see cref="ContextCondition"/> types. Some <see cref="ContextCondition"/> types are in more specific extensions such as <see cref="KingdomEx.ConditionsBuilderKingdomEx">KingdomEx</see>.
  /// </summary>
  /// <inheritdoc cref="ConditionsBuilder"/>
  public static class ConditionsBuilderContextEx
  {

    /// <summary>
    /// Adds <see cref="ContextConditionCasterHasFact"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AcidBomb</term><description>fd101fbc4aacf5d48b76a65e3aa5db6d</description></item>
    /// <item><term>InsightfulContemplationSongArea</term><description>cad5dd5157db3304c80399472bb48bdf</description></item>
    /// <item><term>WrathOfAncestorEnchantment</term><description>4dbc03bd6223b484d8cd9afc3e0369b0</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="fact">
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
    public static ConditionsBuilder CasterHasFact(
        this ConditionsBuilder builder,
        Blueprint<BlueprintUnitFactReference> fact,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionCasterHasFact>();
      element.m_Fact = fact?.Reference;
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionHasBuffFromCaster"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AnomalyDistortionBuff</term><description>599b46d94d454526bf5893a4724d4fbe</description></item>
    /// <item><term>Gibrileth_StenchAreaEffect</term><description>d7a38ef5bd1fffa4aa85a69ff6fe23d4</description></item>
    /// <item><term>WoundWormsLair_BlackDragonFrightfulPresenceArea</term><description>382910feb429e1449b3f8f2a633e3244</description></item>
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
    public static ConditionsBuilder HasBuffFromCaster(
        this ConditionsBuilder builder,
        Blueprint<BlueprintBuffReference> buff,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionHasBuffFromCaster>();
      element.m_Buff = buff?.Reference;
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionHasFact"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>1_FirstDeathAbility</term><description>4445d9d1c21141c6a0bb24baf373ef78</description></item>
    /// <item><term>GrapplingInfusionBuff</term><description>f69a66c0feaa4374b8ca2732ee91a373</description></item>
    /// <item><term>ZeorisDaggerRing_GoverningAllyBuff</term><description>02680be495534b629d543daa89b47079</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="fact">
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
    public static ConditionsBuilder HasFact(
        this ConditionsBuilder builder,
        Blueprint<BlueprintUnitFactReference> fact,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionHasFact>();
      element.m_Fact = fact?.Reference;
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionInContext"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>CarrionStormDamageAbility</term><description>71fef7b9e4564e4a915983e46e2c708d</description></item>
    /// <item><term>KakuentakaDamageAbility</term><description>a5f6e16e23724b9ebaab9f828cb6e7bf</description></item>
    /// <item><term>WrathOfArodenAbility</term><description>77a36621c53f41adab893ac850c70c64</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder InContext(
        this ConditionsBuilder builder,
        ConditionsBuilder conditionsChecker,
        ContextConditionInContext.ContextTargetType? contextTarget = null,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionInContext>();
      element.ConditionsChecker = conditionsChecker?.Build();
      element.ContextTarget = contextTarget ?? element.ContextTarget;
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionAlignment"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AeonAoOGazeArea</term><description>bc346635e3d04df7968249d59ea756ba</description></item>
    /// <item><term>HolySmiteFlesheater</term><description>03d6ca89591b42a4af3ea9eee27a80f0</description></item>
    /// <item><term>WordOfChaos</term><description>69f2e7aff2d1cd148b8075ee476515b1</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder Alignment(
        this ConditionsBuilder builder,
        AlignmentComponent? alignment = null,
        bool? checkCaster = null,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionAlignment>();
      element.Alignment = alignment ?? element.Alignment;
      element.CheckCaster = checkCaster ?? element.CheckCaster;
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionAlignmentDifference"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>DeterminedZeal</term><description>a59b08fdf85465a48b036fd9ef4bcc71</description></item>
    /// <item><term>DivineAnathema</term><description>1777a6ff0ae558749b76766a7a575802</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder AlignmentDifference(
        this ConditionsBuilder builder,
        int? alignmentStepDifference = null,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionAlignmentDifference>();
      element.AlignmentStepDifference = alignmentStepDifference ?? element.AlignmentStepDifference;
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionAlive"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AngelBringBackTouch</term><description>067035da0186d6e43bb4138f433911ee</description></item>
    /// <item><term>GhoulTouchAreaEffect</term><description>e6a5bbb2af2448aa894e6126ef1e9187</description></item>
    /// <item><term>SwarmFeastArea</term><description>23d8c63c3af634843aa11f5a169683b5</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder Alive(
        this ConditionsBuilder builder,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionAlive>();
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionBuffRank"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AlchemistBombsFeature</term><description>c59b2f256f5a70a4d896568658315b7d</description></item>
    /// <item><term>ExtraMercySelection</term><description>8a49abed5be9473da1e1fd1e2457562e</description></item>
    /// <item><term>VengefulCometsBuff</term><description>df180c5adffa4d6dbb16e57fc1c48232</description></item>
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
    /// <param name="fact">
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
    /// <param name="useFactInsteadBuff">
    /// <para>
    /// InfoBox: Любой баф и так является фактом, однако опция имеет смысл: PF-498097
    /// </para>
    /// </param>
    public static ConditionsBuilder BuffRank(
        this ConditionsBuilder builder,
        Blueprint<BlueprintBuffReference>? buff = null,
        Blueprint<BlueprintUnitFactReference>? fact = null,
        bool negate = false,
        ContextValue? rankValue = null,
        bool? useFactInsteadBuff = null)
    {
      var element = ElementTool.Create<ContextConditionBuffRank>();
      element.Buff = buff?.Reference ?? element.Buff;
      if (element.Buff is null)
      {
        element.Buff = BlueprintTool.GetRef<BlueprintBuffReference>(null);
      }
      element.Fact = fact?.Reference ?? element.Fact;
      if (element.Fact is null)
      {
        element.Fact = BlueprintTool.GetRef<BlueprintUnitFactReference>(null);
      }
      element.Not = negate;
      element.RankValue = rankValue ?? element.RankValue;
      if (element.RankValue is null)
      {
        element.RankValue = ContextValues.Constant(0);
      }
      element.UseFactInsteadBuff = useFactInsteadBuff ?? element.UseFactInsteadBuff;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionCasterHasBuffWithDescriptor"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AnimalisticPerseveranceFeature</term><description>1a3d8a5e342c47a7b721ca699a9613ed</description></item>
    /// <item><term>BracersOfAnimalFuryFeature</term><description>0556a23dd7591fb49a18af3095be631d</description></item>
    /// <item><term>ShadowMadnessBuff</term><description>79aa1817f0b0447d8c81e59ec5c79b30</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder CasterHasBuffWithDescriptor(
        this ConditionsBuilder builder,
        bool negate = false,
        SpellDescriptorWrapper? spellDescriptor = null)
    {
      var element = ElementTool.Create<ContextConditionCasterHasBuffWithDescriptor>();
      element.Not = negate;
      element.SpellDescriptor = spellDescriptor ?? element.SpellDescriptor;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionCasterWeaponInTwoHands"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>BracersOfDominanceFeature</term><description>cdc4f29bc423d454e9af87a514a14de7</description></item>
    /// <item><term>TwoWeaponFeintBuff</term><description>621523572cfe4dc48ee1bdddba2f4725</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder CasterWeaponInTwoHands(
        this ConditionsBuilder builder,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionCasterWeaponInTwoHands>();
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionCharacterClass"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AasimarHaloToggleAbility</term><description>248bbb747c273684d9fdf2ed38935def</description></item>
    /// <item><term>DragonDiscipleClass</term><description>72051275b1dbb2d42ba9118237794f7c</description></item>
    /// <item><term>WrathOfArodenAbility</term><description>77a36621c53f41adab893ac850c70c64</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="clazz">
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
    public static ConditionsBuilder CharacterClass(
        this ConditionsBuilder builder,
        bool? checkCaster = null,
        Blueprint<BlueprintCharacterClassReference>? clazz = null,
        int? minLevel = null,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionCharacterClass>();
      element.CheckCaster = checkCaster ?? element.CheckCaster;
      element.m_Class = clazz?.Reference ?? element.m_Class;
      if (element.m_Class is null)
      {
        element.m_Class = BlueprintTool.GetRef<BlueprintCharacterClassReference>(null);
      }
      element.MinLevel = minLevel ?? element.MinLevel;
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionCompare"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>Areelu_UnbreakableDefenseBuff</term><description>57572f514d5b49bf98432026c80382c3</description></item>
    /// <item><term>DragonLevel1MaxAbilityWisdomFeature</term><description>b0b5d090fb6e45acb818d6efedf7b872</description></item>
    /// <item><term>TransmutationSchoolStrengthAbility</term><description>aadee249a033b2747b63344a758e91be</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder Compare(
        this ConditionsBuilder builder,
        ContextValue? checkValue = null,
        bool negate = false,
        ContextValue? targetValue = null,
        ContextConditionCompare.Type? type = null)
    {
      var element = ElementTool.Create<ContextConditionCompare>();
      element.CheckValue = checkValue ?? element.CheckValue;
      if (element.CheckValue is null)
      {
        element.CheckValue = ContextValues.Constant(0);
      }
      element.Not = negate;
      element.TargetValue = targetValue ?? element.TargetValue;
      if (element.TargetValue is null)
      {
        element.TargetValue = ContextValues.Constant(0);
      }
      element.m_Type = type ?? element.m_Type;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionCompareCasterHP"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>BracersOfOverwhelmingVigorFeature</term><description>b34921b9358e1154783b98fb6aac3cae</description></item>
    /// <item><term>PlagueDeathQuarterstaffFeature</term><description>357d9df84a28fa949a575e8841c4e75e</description></item>
    /// <item><term>ZonKuthonScarHalfHPTriggerBuff</term><description>b5eb1d0094f744889ca22bb4cfc1e648</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder CompareCasterHP(
        this ConditionsBuilder builder,
        ContextConditionCompareCasterHP.CompareType? compareType = null,
        bool negate = false,
        ContextValue? value = null)
    {
      var element = ElementTool.Create<ContextConditionCompareCasterHP>();
      element.m_CompareType = compareType ?? element.m_CompareType;
      element.Not = negate;
      element.Value = value ?? element.Value;
      if (element.Value is null)
      {
        element.Value = ContextValues.Constant(0);
      }
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionCompareTargetHP"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>3_ThirdDeathAbility</term><description>b8cdd783f7d14703870022a5f0fd5e36</description></item>
    /// <item><term>Kakuen_takaRepairShieldAreaEffect</term><description>55fc2bd8179a4bcb9034a65706609eb4</description></item>
    /// <item><term>Unused_SZ_1</term><description>204c7132bafa41c993ffdb9ae675d5eb</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder CompareTargetHP(
        this ConditionsBuilder builder,
        ContextConditionCompareTargetHP.CompareType? compareType = null,
        bool negate = false,
        ContextValue? value = null)
    {
      var element = ElementTool.Create<ContextConditionCompareTargetHP>();
      element.m_CompareType = compareType ?? element.m_CompareType;
      element.Not = negate;
      element.Value = value ?? element.Value;
      if (element.Value is null)
      {
        element.Value = ContextValues.Constant(0);
      }
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionDamageTransferIsApplicable"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>ShiftersEdgeCheckBuff</term><description>8522c7e3c56e4bfc8cde0c298243290f</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder DamageTransferIsApplicable(
        this ConditionsBuilder builder,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionDamageTransferIsApplicable>();
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionDistanceToTarget"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>BurstOfSonicEnergy</term><description>b5a2d0e400dd38e428c953f8a2be5f0b</description></item>
    /// <item><term>MajorConsumeFleshUndeadAreaEffect</term><description>6d1317c8ca3b462c9b0db3d5f4d11e68</description></item>
    /// <item><term>WitheringFleshAreaEffect</term><description>7ba9b0377e784c24abf75fe651fd1cea</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder DistanceToTarget(
        this ConditionsBuilder builder,
        Feet? distanceGreater = null,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionDistanceToTarget>();
      element.DistanceGreater = distanceGreater ?? element.DistanceGreater;
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionFavoredEnemy"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>FavoredEnemySpellcasting</term><description>0226d84afe68462da8a392798f1225b8</description></item>
    /// <item><term>MasterSpyCasterBuff</term><description>ff2e84b215b187347a406670ab2f5cf7</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder FavoredEnemy(
        this ConditionsBuilder builder,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionFavoredEnemy>();
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionGender"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>NereidBeguilingAuraAreaEffect</term><description>466ec47d91f209646aa1b66a797b7d8d</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder Gender(
        this ConditionsBuilder builder,
        Gender? gender = null,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionGender>();
      element.Gender = gender ?? element.Gender;
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionHasBuff"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AirBlastAbility</term><description>31f668b12011e344aa542aa07ab6c8d9</description></item>
    /// <item><term>FlameAoe</term><description>69e3532f0321e4144bcc0d0d3f372ca5</description></item>
    /// <item><term>ZeorisDaggerRing_BetrayalFeature</term><description>1f6fabee66d54992bc912236d36b50f8</description></item>
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
    public static ConditionsBuilder HasBuff(
        this ConditionsBuilder builder,
        Blueprint<BlueprintBuffReference>? buff = null,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionHasBuff>();
      element.m_Buff = buff?.Reference ?? element.m_Buff;
      if (element.m_Buff is null)
      {
        element.m_Buff = BlueprintTool.GetRef<BlueprintBuffReference>(null);
      }
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionHasBuffFromThisAreaEffect"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>PillarOfLifeaArea</term><description>7d0cebd89884679469533be8b680d55c</description></item>
    /// <item><term>VescavorQueenGibberAreaEffect</term><description>acbb8f87c5d98164dbdc1aee0f9eda2b</description></item>
    /// <item><term>VescavorSwarmGibberAreaEffect</term><description>a80c90f3223d8324ea0c1d75c45bd331</description></item>
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
    public static ConditionsBuilder HasBuffFromThisAreaEffect(
        this ConditionsBuilder builder,
        Blueprint<BlueprintBuffReference>? buff = null,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionHasBuffFromThisAreaEffect>();
      element.m_Buff = buff?.Reference ?? element.m_Buff;
      if (element.m_Buff is null)
      {
        element.m_Buff = BlueprintTool.GetRef<BlueprintBuffReference>(null);
      }
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionHasBuffImmunityWithDescriptor"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>DLC6_FirstDragonBreathWeapon</term><description>d56ae3d0f38c44a2a1d385e234aef613</description></item>
    /// <item><term>PurpleWormSwallowWholeFeature</term><description>dee864aec4a0d344b913dd27a4b504cb</description></item>
    /// <item><term>VrockSporesAbility</term><description>19400435d35a3064b975861ef0a2c462</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder HasBuffImmunityWithDescriptor(
        this ConditionsBuilder builder,
        bool? checkBuffDescriptorComponent = null,
        bool? checkSpellDescriptorComponent = null,
        bool negate = false,
        SpellDescriptorWrapper? spellDescriptor = null)
    {
      var element = ElementTool.Create<ContextConditionHasBuffImmunityWithDescriptor>();
      element.CheckBuffDescriptorComponent = checkBuffDescriptorComponent ?? element.CheckBuffDescriptorComponent;
      element.CheckSpellDescriptorComponent = checkSpellDescriptorComponent ?? element.CheckSpellDescriptorComponent;
      element.Not = negate;
      element.SpellDescriptor = spellDescriptor ?? element.SpellDescriptor;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionHasBuffWithDescriptor"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AngelfireApostleVersatileChannelRestorationLesser</term><description>95e3e99ea2f5932408b0310ebc7e9af1</description></item>
    /// <item><term>MantisZealotMantisSwarmFeature</term><description>aba4b42c3cad4bcdaaf79b1a52778591</description></item>
    /// <item><term>ZonKuthonBuff</term><description>83ee9bf48b4249858df8f8ea5fe6ef06</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder HasBuffWithDescriptor(
        this ConditionsBuilder builder,
        bool negate = false,
        SpellDescriptorWrapper? spellDescriptor = null)
    {
      var element = ElementTool.Create<ContextConditionHasBuffWithDescriptor>();
      element.Not = negate;
      element.SpellDescriptor = spellDescriptor ?? element.SpellDescriptor;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionHasItem"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>123</term><description>535217378b8a4ca3ba5a45f0002de07c</description></item>
    /// <item><term>Cue_0018</term><description>31cfc8141e134d189d64631a3ce69d93</description></item>
    /// <item><term>ZeorisDaggerEtude</term><description>ad64557f3ad74ff0b36fce6364df6ab2</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="itemToCheck">
    /// <para>
    /// Blueprint of type BlueprintItem. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public static ConditionsBuilder HasItem(
        this ConditionsBuilder builder,
        Blueprint<BlueprintItemReference>? itemToCheck = null,
        bool? money = null,
        bool negate = false,
        int? quantity = null)
    {
      var element = ElementTool.Create<ContextConditionHasItem>();
      element.m_ItemToCheck = itemToCheck?.Reference ?? element.m_ItemToCheck;
      if (element.m_ItemToCheck is null)
      {
        element.m_ItemToCheck = BlueprintTool.GetRef<BlueprintItemReference>(null);
      }
      element.Money = money ?? element.Money;
      element.Not = negate;
      element.Quantity = quantity ?? element.Quantity;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionHasItemCharges"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>BaneNonHumanFeature</term><description>54aa118979b44497b4db1bb861f78db5</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="itemToCheck">
    /// <para>
    /// Blueprint of type BlueprintItem. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public static ConditionsBuilder HasItemCharges(
        this ConditionsBuilder builder,
        Blueprint<BlueprintItemReference>? itemToCheck = null,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionHasItemCharges>();
      element.m_ItemToCheck = itemToCheck?.Reference ?? element.m_ItemToCheck;
      if (element.m_ItemToCheck is null)
      {
        element.m_ItemToCheck = BlueprintTool.GetRef<BlueprintItemReference>(null);
      }
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionHasTouchSpellCharge"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>Mageblade</term><description>eb130f652be2dc14b9a5f63608672021</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder HasTouchSpellCharge(
        this ConditionsBuilder builder,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionHasTouchSpellCharge>();
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionHasUniqueBuff"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>DLC3_RageConfusionIsland</term><description>6401e7d62cf6424a95a858bff65b2000</description></item>
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
    public static ConditionsBuilder HasUniqueBuff(
        this ConditionsBuilder builder,
        Blueprint<BlueprintBuffReference>? buff = null,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionHasUniqueBuff>();
      element.m_Buff = buff?.Reference ?? element.m_Buff;
      if (element.m_Buff is null)
      {
        element.m_Buff = BlueprintTool.GetRef<BlueprintBuffReference>(null);
      }
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionHitDice"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>Arbitrament</term><description>0f5bd128c76dd374b8cb9111e3b5186b</description></item>
    /// <item><term>ColorSpraySnowball221</term><description>8edf1ce73f4d4ce6a7064178aaf63b21</description></item>
    /// <item><term>WoundWormsLair_BlackDragonFrightfulPresenceArea</term><description>382910feb429e1449b3f8f2a633e3244</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder HitDice(
        this ConditionsBuilder builder,
        bool? addSharedValue = null,
        int? hitDice = null,
        bool negate = false,
        AbilitySharedValue? sharedValue = null)
    {
      var element = ElementTool.Create<ContextConditionHitDice>();
      element.AddSharedValue = addSharedValue ?? element.AddSharedValue;
      element.HitDice = hitDice ?? element.HitDice;
      element.Not = negate;
      element.SharedValue = sharedValue ?? element.SharedValue;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionIsAlly"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AcidBomb</term><description>fd101fbc4aacf5d48b76a65e3aa5db6d</description></item>
    /// <item><term>EclipseChillOnBuff</term><description>1d585582fbe72e14aadc5cd7985c06f4</description></item>
    /// <item><term>WrathOfTheUndeadArea</term><description>22e31702587142ddb99391d589ba538b</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder IsAlly(
        this ConditionsBuilder builder,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionIsAlly>();
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionIsAmuletEquipped"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>HammerOfMasterpieceAbility</term><description>0781ebffe79c5ee4caf127956b9574eb</description></item>
    /// <item><term>HammerOfMasterpieceEnchantment</term><description>f0a7d830ec5bfa44ba77996938db980f</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder IsAmuletEquipped(
        this ConditionsBuilder builder,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionIsAmuletEquipped>();
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionIsAnimalCompanion"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AnimalInsightArea</term><description>d3c9117d43833df49a253df19377bbfe</description></item>
    /// <item><term>FafnheirDeathCurseFeature</term><description>0167db2f420141c4860851b62c5d0d55</description></item>
    /// <item><term>HippogriffFlyingAttackAbility</term><description>7d0bc62733414cabae1466df04f04910</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder IsAnimalCompanion(
        this ConditionsBuilder builder,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionIsAnimalCompanion>();
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionIsCaster"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AllRoundDefenseAreaEffect</term><description>5e56c4ff29094864aa23ec9b5b4ccf57</description></item>
    /// <item><term>Halaseliax_FrightfulPresenceArea</term><description>b2114357604b47809a3808ea6973ce72</description></item>
    /// <item><term>ZeroState</term><description>c6195ff24255d3f46a26323de9f1187a</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder IsCaster(
        this ConditionsBuilder builder,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionIsCaster>();
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionIsEnemy"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AcidBombMaceAbility</term><description>100a5f494cf264f4690ae931a10d2d94</description></item>
    /// <item><term>HexChannelerChannelPositiveHarm</term><description>fb917ad147d846e42ad22c8e14f44b79</description></item>
    /// <item><term>ZippyMagicFeature</term><description>30b4200f897ba25419ba3a292aed4053</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder IsEnemy(
        this ConditionsBuilder builder,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionIsEnemy>();
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionIsFlanked"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>MarksmansSteadyHandFeature</term><description>86baea5d6bde19d4b9845c5c33eeec1b</description></item>
    /// <item><term>TricksterSneakyQuack</term><description>bf41d492ff138ae4e9775e6fd9c8011e</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder IsFlanked(
        this ConditionsBuilder builder,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionIsFlanked>();
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionIsFlatFooted"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AmbuscadingSpell</term><description>2fb48bed3746431bb3080c34f11597da</description></item>
    /// <item><term>StagHelmetFeature</term><description>32c73d4df6c4f4746a748bc1f140d629</description></item>
    /// <item><term>VigilantWatchFeature</term><description>d4cf7afc49b81e34989f2dfa76889fed</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder IsFlatFooted(
        this ConditionsBuilder builder,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionIsFlatFooted>();
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionIsHelpless"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>MusicOfDeathEnchantment</term><description>183a4d2cc996c6f4db8641bed4b3b0c1</description></item>
    /// <item><term>SoundOfVoidEnchantment</term><description>69df5e137a08d9b4ead5d87bf4d5d0ac</description></item>
    /// <item><term>TheDissectorEnchantment</term><description>3e90ab8205854cd591538c1aff04b901</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder IsHelpless(
        this ConditionsBuilder builder,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionIsHelpless>();
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionIsInCombat"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AngelHaloArea</term><description>7aa654dc15f051b4e865dc82b6765b0c</description></item>
    /// <item><term>DLC3_VeryHotIslandMediumArmorBuff</term><description>c14aad21265a4b309d2b1d2754285863</description></item>
    /// <item><term>ZonKuthonScarBuff</term><description>fbb677d91f924b99a3610ae79f6468fa</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder IsInCombat(
        this ConditionsBuilder builder,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionIsInCombat>();
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionIsMainCharacter"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AeonMythicClass</term><description>15a85e67b7d69554cab9ed5830d0268e</description></item>
    /// <item><term>FafnheirDeathCurseTimerBuff</term><description>848cac6881f04d1fa7ddf285d740efe7</description></item>
    /// <item><term>SwarmProtectCorpseArea</term><description>4634d1da7c394ec4a49cb38e59e91f44</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder IsMainCharacter(
        this ConditionsBuilder builder,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionIsMainCharacter>();
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionIsMainTarget"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AbandonedKeep_AcidTrap</term><description>e7dadeb8b1d78a341bb4357b502da424</description></item>
    /// <item><term>ExplodingArrowsIceBlastAbility</term><description>35d2f23a727a4e358ea230525c6afd9d</description></item>
    /// <item><term>WideSweepAbility</term><description>69811d984ba4ab8419873b09c1641e36</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder IsMainTarget(
        this ConditionsBuilder builder,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionIsMainTarget>();
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionIsPartyMember"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AloneinTheDarkLastManStandingFeature</term><description>3ca1d2a2633c46b69236fbc637db6980</description></item>
    /// <item><term>FafnheirWildMagicBuff</term><description>c3fffad183c54cf29c58bcfd63bbbae1</description></item>
    /// <item><term>WoundingBattleaxeBleedBuff</term><description>b6452a2ac912260409a18aa8e69e60f7</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder IsPartyMember(
        this ConditionsBuilder builder,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionIsPartyMember>();
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionIsPetDead"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AnimalFocusBearBuff</term><description>fa25fec82271c93478194c52a20ce733</description></item>
    /// <item><term>AnimalFocusMouseBuff</term><description>127de9efe375a364d94fc68d94ad231a</description></item>
    /// <item><term>AnimalFocusTigerBuff</term><description>18e0d3842308de14ca3fde356bf92b92</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder IsPetDead(
        this ConditionsBuilder builder,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionIsPetDead>();
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionIsRing1Equipped"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>HammerOfMasterpieceAbility</term><description>0781ebffe79c5ee4caf127956b9574eb</description></item>
    /// <item><term>HammerOfMasterpieceEnchantment</term><description>f0a7d830ec5bfa44ba77996938db980f</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder IsRing1Equipped(
        this ConditionsBuilder builder,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionIsRing1Equipped>();
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionIsRing2Equipped"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>HammerOfMasterpieceAbility</term><description>0781ebffe79c5ee4caf127956b9574eb</description></item>
    /// <item><term>HammerOfMasterpieceEnchantment</term><description>f0a7d830ec5bfa44ba77996938db980f</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder IsRing2Equipped(
        this ConditionsBuilder builder,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionIsRing2Equipped>();
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionIsShieldEquipped"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AbruptEndEnchantment</term><description>66f1ac1f205e99f4e83c9b3aa8f0b0b1</description></item>
    /// <item><term>MagicalVestmentShield</term><description>adcda176d1756eb45bd5ec9592073b09</description></item>
    /// <item><term>WarpriestShieldbearerChannelPositiveHarm</term><description>894e20539c353c74ab2733a056351947</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder IsShieldEquipped(
        this ConditionsBuilder builder,
        bool? checkCaster = null,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionIsShieldEquipped>();
      element.CheckCaster = checkCaster ?? element.CheckCaster;
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionIsTwoHandedEquipped"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AbruptEndEnchantment</term><description>66f1ac1f205e99f4e83c9b3aa8f0b0b1</description></item>
    /// <item><term>FuriousFocus</term><description>f09b89812cc94b89a09069671002b899</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder IsTwoHandedEquipped(
        this ConditionsBuilder builder,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionIsTwoHandedEquipped>();
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionIsUnconscious"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>DeepSlumber</term><description>7658b74f626c56a49939d9c20580885e</description></item>
    /// <item><term>RainbowPattern</term><description>4b8265132f9c8174f87ce7fa6d0fe47b</description></item>
    /// <item><term>ZonKuthonScarBuff</term><description>fbb677d91f924b99a3610ae79f6468fa</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder IsUnconscious(
        this ConditionsBuilder builder,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionIsUnconscious>();
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionIsWeaponEquipped"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>Achaekek_Buff</term><description>b9c4527e6cfc4fc39f4abdc76f91e279</description></item>
    /// <item><term>FinesseTrainingTalon</term><description>f1017d46f56547a3b10dc9b9b5b8da5a</description></item>
    /// <item><term>WeaponFocus</term><description>1e1f627d26ad36f43bbd26cc2bf8ac7e</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder IsWeaponEquipped(
        this ConditionsBuilder builder,
        bool? bothHandsAreEmpty = null,
        WeaponCategory? category = null,
        bool? checkOnCaster = null,
        bool? checkSlot = null,
        bool? checkWeaponCategory = null,
        bool? checkWeaponRangeType = null,
        bool? justCheckEmptyHand = null,
        bool negate = false,
        WeaponRangeType? rangeType = null,
        ContextConditionIsWeaponEquipped.CheckedSlot? slot = null)
    {
      var element = ElementTool.Create<ContextConditionIsWeaponEquipped>();
      element.BothHandsAreEmpty = bothHandsAreEmpty ?? element.BothHandsAreEmpty;
      element.Category = category ?? element.Category;
      element.CheckOnCaster = checkOnCaster ?? element.CheckOnCaster;
      element.CheckSlot = checkSlot ?? element.CheckSlot;
      element.CheckWeaponCategory = checkWeaponCategory ?? element.CheckWeaponCategory;
      element.CheckWeaponRangeType = checkWeaponRangeType ?? element.CheckWeaponRangeType;
      element.JustCheckEmptyHand = justCheckEmptyHand ?? element.JustCheckEmptyHand;
      element.Not = negate;
      element.RangeType = rangeType ?? element.RangeType;
      element.Slot = slot ?? element.Slot;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionMaximumBurn"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>ElementalEngineBurnoutTriggerFeature</term><description>090d39a5813d4537ba24b55fff7fe6be</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder MaximumBurn(
        this ConditionsBuilder builder,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionMaximumBurn>();
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionPeaceful"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>SoulsCloakCurseBuff</term><description>40f948d8e5ee2534eb3d701f256f96b5</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder Peaceful(
        this ConditionsBuilder builder,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionPeaceful>();
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionSharedValueHigher"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AmiriCampBuff</term><description>f04177fdba7bb324589b7f2b0fd67604</description></item>
    /// <item><term>ShadowShamanShadowsAbility</term><description>085b4d4d0c5747bb8b1173e914c24d20</description></item>
    /// <item><term>WitchHexMajorHealingAbility</term><description>3408c351753aa9049af25af31ebef624</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder SharedValueHigher(
        this ConditionsBuilder builder,
        int? higherOrEqual = null,
        bool? inverted = null,
        bool negate = false,
        AbilitySharedValue? sharedValue = null)
    {
      var element = ElementTool.Create<ContextConditionSharedValueHigher>();
      element.HigherOrEqual = higherOrEqual ?? element.HigherOrEqual;
      element.Inverted = inverted ?? element.Inverted;
      element.Not = negate;
      element.SharedValue = sharedValue ?? element.SharedValue;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionSharedValueHitDice"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>BloodHazeEffectBuff</term><description>06bd4a59646b7fa468166d1c745f31dc</description></item>
    /// <item><term>SecretOfHookingAndSummoning</term><description>72ae181281075c74ea2d1ae74ad95597</description></item>
    /// <item><term>WitchHexLayToRestAbility</term><description>1bb5466b9bfcb5e47b9f667dad5784f9</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder SharedValueHitDice(
        this ConditionsBuilder builder,
        bool? inverted = null,
        bool negate = false,
        AbilitySharedValue? sharedValue = null)
    {
      var element = ElementTool.Create<ContextConditionSharedValueHitDice>();
      element.Inverted = inverted ?? element.Inverted;
      element.Not = negate;
      element.SharedValue = sharedValue ?? element.SharedValue;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionSize"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AeonNormalizeSizeGazeEnemyBuff</term><description>dc42e955adbd444fbb3082687080117b</description></item>
    /// <item><term>DLC6PrimalInevitable_Buff_AeonGazeEnemy</term><description>16b4793b6eba42779fbc5677028f82fa</description></item>
    /// <item><term>WintersMarkEnchantment</term><description>0641db56869d87c4bb387e5ae4a18a0e</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder Size(
        this ConditionsBuilder builder,
        bool? checkCaster = null,
        ContextConditionSize.SizeType? checkedSizeType = null,
        bool? exactlyEquals = null,
        bool? invert = null,
        bool negate = false,
        Size? size = null)
    {
      var element = ElementTool.Create<ContextConditionSize>();
      element.CheckCaster = checkCaster ?? element.CheckCaster;
      element.CheckedSizeType = checkedSizeType ?? element.CheckedSizeType;
      element.ExactlyEquals = exactlyEquals ?? element.ExactlyEquals;
      element.Invert = invert ?? element.Invert;
      element.Not = negate;
      element.Size = size ?? element.Size;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionStatValue"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AeonAoOGazeAllyBuff</term><description>a85b9737fba146dcb3468526d67fbc0e</description></item>
    /// <item><term>FeintAbility</term><description>1bb6f0b196aa457ba80bdb312dc64952</description></item>
    /// <item><term>WeaponFocus</term><description>1e1f627d26ad36f43bbd26cc2bf8ac7e</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder StatValue(
        this ConditionsBuilder builder,
        int? n = null,
        bool negate = false,
        StatType? stat = null)
    {
      var element = ElementTool.Create<ContextConditionStatValue>();
      element.N = n ?? element.N;
      element.Not = negate;
      element.Stat = stat ?? element.Stat;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionTargetCanSeeInvisible"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>BlinkBuff</term><description>c168c6a0e471e924b8c69b31c6352587</description></item>
    /// <item><term>CallingForAFeastBlinkBuff</term><description>cf9a122d832a498395b56a92233af763</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder TargetCanSeeInvisible(
        this ConditionsBuilder builder,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionTargetCanSeeInvisible>();
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionTargetIsArcaneCaster"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>DLC3_IllusionIslandCasterBuff</term><description>3f2bbe4dbb22461aa8392a5e46de62bc</description></item>
    /// <item><term>Feeblemind</term><description>444eed6e26f773a40ab6e4d160c67faa</description></item>
    /// <item><term>SorceriousGownFeature</term><description>40c8515843864766844ab8b69ef1f29b</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder TargetIsArcaneCaster(
        this ConditionsBuilder builder,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionTargetIsArcaneCaster>();
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionTargetIsBlueprint"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>EnhancementBonusWilloWisp</term><description>012f72c2749c2e94eb3c389f3f077aac</description></item>
    /// <item><term>FXActionHolder</term><description>8b6dfee48d134485ae553b510662f601</description></item>
    /// <item><term>ThunderingClawPet</term><description>e95c2acd75e1d964eaece4a9958d31d5</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="unit">
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
    public static ConditionsBuilder TargetIsBlueprint(
        this ConditionsBuilder builder,
        bool negate = false,
        Blueprint<BlueprintUnitReference>? unit = null)
    {
      var element = ElementTool.Create<ContextConditionTargetIsBlueprint>();
      element.Not = negate;
      element.m_Unit = unit?.Reference ?? element.m_Unit;
      if (element.m_Unit is null)
      {
        element.m_Unit = BlueprintTool.GetRef<BlueprintUnitReference>(null);
      }
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionTargetIsDivineCaster"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>DemodandTarryLairMiniboss_TitansGodslayer</term><description>e990ddcda355abd4396fac5e49895578</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder TargetIsDivineCaster(
        this ConditionsBuilder builder,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionTargetIsDivineCaster>();
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionTargetIsYourself"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>ArcanistExploitArmoredMaskAbility</term><description>2d7d510c6e2e3e54ab9eee84a41fa2cf</description></item>
    /// <item><term>FiendTotemGreaterArea</term><description>9ebde3219b12ca84c8e734a8430a57f8</description></item>
    /// <item><term>WreckingBlowsEffectBuff</term><description>15dd42009de61334692b22fd7a576b79</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder TargetIsYourself(
        this ConditionsBuilder builder,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionTargetIsYourself>();
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionUnconsciousAllyFarThan"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>ParagonOfDefendersAuraBuff</term><description>b348cf228b07b534cb315e7c54f95379</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder UnconsciousAllyFarThan(
        this ConditionsBuilder builder,
        Feet? distance = null,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionUnconsciousAllyFarThan>();
      element.Distance = distance ?? element.Distance;
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextConditionWeaponAnimationStyle"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>FuriousFocus</term><description>f09b89812cc94b89a09069671002b899</description></item>
    /// <item><term>GreyGarrison_SuperMythicBuff</term><description>4b11247a4988c254fb9d1cd67f0b1e4a</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder WeaponAnimationStyle(
        this ConditionsBuilder builder,
        WeaponAnimationStyle? animationStyle = null,
        bool? checkOnCaster = null,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextConditionWeaponAnimationStyle>();
      element.AnimationStyle = animationStyle ?? element.AnimationStyle;
      element.CheckOnCaster = checkOnCaster ?? element.CheckOnCaster;
      element.Not = negate;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ContextSwarmHasEnemiesInInnerCircle"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>BloodlineSerpentineDenOfSpidersSpiderSwarmDamageBuff</term><description>9c414efda39e67344846171c1547edc1</description></item>
    /// <item><term>LocustSwarmDamageBuff</term><description>e9e341bff1efce2469bdf6577672bb4d</description></item>
    /// <item><term>VescavorSwarmDamageBuff</term><description>ddc847a49246ded4f93fe2bf0e2a7dab</description></item>
    /// </list>
    /// </remarks>
    public static ConditionsBuilder ContextSwarmHasEnemiesInInnerCircle(
        this ConditionsBuilder builder,
        bool negate = false)
    {
      var element = ElementTool.Create<ContextSwarmHasEnemiesInInnerCircle>();
      element.Not = negate;
      return builder.Add(element);
    }
  }
}

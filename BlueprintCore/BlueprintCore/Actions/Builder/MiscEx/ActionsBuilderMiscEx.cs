//***** AUTO-GENERATED - DO NOT EDIT *****//

using BlueprintCore.Actions.Builder;
using BlueprintCore.Utils;
using Kingmaker;
using Kingmaker.Achievements.Actions;
using Kingmaker.Achievements.Blueprints;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.Blueprints.Items;
using Kingmaker.Blueprints.Loot;
using Kingmaker.Blueprints.Root;
using Kingmaker.Designers.EventConditionActionSystem.Actions;
using Kingmaker.DLC;
using Kingmaker.Dungeon.Actions;
using Kingmaker.ElementsSystem;
using Kingmaker.Localization;
using Kingmaker.Tutorial;
using Kingmaker.Tutorial.Actions;
using Kingmaker.UI.MVVM._VM.ServiceWindows.Inventory;
using Kingmaker.UnitLogic.FactLogic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlueprintCore.Actions.Builder.MiscEx
{
  /// <summary>
  /// Extension to <see cref="ActionsBuilder"/> for actions without a better extension container such as achievements vendor actions, and CustomEvent.
  /// </summary>
  /// <inheritdoc cref="ActionsBuilder"/>
  public static class ActionsBuilderMiscEx
  {

    /// <summary>
    /// Adds <see cref="ActionAchievementUnlock"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>01_DevouredByDarkness</term><description>67d3321ed01a4e58a9ed3e13f94f1d04</description></item>
    /// <item><term>Cue_23</term><description>36ad062f4c39429ea95fab944c7ec1bb</description></item>
    /// <item><term>Unfair Challenge</term><description>deef16f3e31e47a3aa91df404fe0edd5</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="achievement">
    /// <para>
    /// Blueprint of type AchievementData. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public static ActionsBuilder AchievementUnlock(
        this ActionsBuilder builder,
        Blueprint<AchievementDataReference> achievement)
    {
      var element = ElementTool.Create<ActionAchievementUnlock>();
      element.m_Achievement = achievement?.Reference;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="AddPremiumReward"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>Answer_0004</term><description>61ec9675e81645c9b9323d29ee23456c</description></item>
    /// <item><term>DLC6_TavernRebuilded_DaeranRomance_Preset</term><description>4131a6d9b4c9408ba43e0b0df3d3e224</description></item>
    /// <item><term>MortaCollabPremiumReward</term><description>a57e8f79685648de87267ca248cad82d</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="dlcReward">
    /// <para>
    /// Blueprint of type BlueprintDlcReward. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    /// <param name="items">
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
    /// <param name="playerFeatures">
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
    public static ActionsBuilder AddPremiumReward(
        this ActionsBuilder builder,
        ActionsBuilder? additionalActions = null,
        Blueprint<BlueprintDlcRewardReference>? dlcReward = null,
        List<Blueprint<BlueprintItemReference>>? items = null,
        List<Blueprint<BlueprintFeatureReference>>? playerFeatures = null)
    {
      var element = ElementTool.Create<AddPremiumReward>();
      element.AdditionalActions = additionalActions?.Build() ?? element.AdditionalActions;
      if (element.AdditionalActions is null)
      {
        element.AdditionalActions = Utils.Constants.Empty.Actions;
      }
      element.m_DlcReward = dlcReward?.Reference ?? element.m_DlcReward;
      if (element.m_DlcReward is null)
      {
        element.m_DlcReward = BlueprintTool.GetRef<BlueprintDlcRewardReference>(null);
      }
      element.Items = items?.Select(bp => bp.Reference)?.ToList() ?? element.Items;
      if (element.Items is null)
      {
        element.Items = new();
      }
      element.PlayerFeatures = playerFeatures?.Select(bp => bp.Reference)?.ToList() ?? element.PlayerFeatures;
      if (element.PlayerFeatures is null)
      {
        element.PlayerFeatures = new();
      }
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="AddVendorItemsAction"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>Chapter02</term><description>0e20d73ea0da6a94d94a6b42035a1ce0</description></item>
    /// <item><term>DLC3_Salesman_dialogue</term><description>f98723d13d2a4945b060c0f0da601d14</description></item>
    /// <item><term>DLC5_VendorsAfterStorasta</term><description>63d639a46f824e62ad94401ab2b1bade</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="vendorTable">
    /// <para>
    /// Blueprint of type BlueprintUnitLoot. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public static ActionsBuilder AddVendorItemsAction(
        this ActionsBuilder builder,
        VendorEvaluator? vendorEvaluator = null,
        Blueprint<BlueprintUnitLootReference>? vendorTable = null)
    {
      var element = ElementTool.Create<AddVendorItemsAction>();
      builder.Validate(vendorEvaluator);
      element.m_VendorEvaluator = vendorEvaluator ?? element.m_VendorEvaluator;
      element.m_VendorTable = vendorTable?.Reference ?? element.m_VendorTable;
      if (element.m_VendorTable is null)
      {
        element.m_VendorTable = BlueprintTool.GetRef<BlueprintUnitLootReference>(null);
      }
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ClearVendorTable"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>DHLost_Mechanic</term><description>e5961409f47c4d0f9c19e7af184a8eb6</description></item>
    /// <item><term>Test_Bebilith Blueprint Camping Encounter</term><description>f2f8355d4bc8aa34195eeb2f5cf66645</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="table">
    /// <para>
    /// Blueprint of type BlueprintSharedVendorTable. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public static ActionsBuilder ClearVendorTable(
        this ActionsBuilder builder,
        Blueprint<BlueprintSharedVendorTableReference>? table = null)
    {
      var element = ElementTool.Create<ClearVendorTable>();
      element.m_Table = table?.Reference ?? element.m_Table;
      if (element.m_Table is null)
      {
        element.m_Table = BlueprintTool.GetRef<BlueprintSharedVendorTableReference>(null);
      }
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ClearSharedVendorTable"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>DungeonRoot</term><description>096f36d4e55b49129ddd2211b2c50513</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="sharedTable">
    /// <para>
    /// Blueprint of type BlueprintSharedVendorTable. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public static ActionsBuilder ClearSharedVendorTable(
        this ActionsBuilder builder,
        Blueprint<BlueprintSharedVendorTableReference>? sharedTable = null)
    {
      var element = ElementTool.Create<ClearSharedVendorTable>();
      element.m_SharedTable = sharedTable?.Reference ?? element.m_SharedTable;
      if (element.m_SharedTable is null)
      {
        element.m_SharedTable = BlueprintTool.GetRef<BlueprintSharedVendorTableReference>(null);
      }
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="CreateCustomCompanion"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>Answer_0004</term><description>2834afb4ff974f60bd8f802391979448</description></item>
    /// <item><term>Cue_10</term><description>15e6957db46c4ab593187c44f8bb4014</description></item>
    /// <item><term>Cue_8</term><description>626c4ccc37be4bfab1dddebb8c4c4e6b</description></item>
    /// </list>
    /// </remarks>
    public static ActionsBuilder CreateCustomCompanion(
        this ActionsBuilder builder,
        bool? forFree = null,
        LocatorEvaluator? locator = null,
        bool? lockInUi = null,
        bool? matchPlayerXpExactly = null,
        bool? noEquipment = null,
        ActionsBuilder? onCreate = null)
    {
      var element = ElementTool.Create<CreateCustomCompanion>();
      element.ForFree = forFree ?? element.ForFree;
      builder.Validate(locator);
      element.Locator = locator ?? element.Locator;
      element.LockInUi = lockInUi ?? element.LockInUi;
      element.MatchPlayerXpExactly = matchPlayerXpExactly ?? element.MatchPlayerXpExactly;
      element.NoEquipment = noEquipment ?? element.NoEquipment;
      element.OnCreate = onCreate?.Build() ?? element.OnCreate;
      if (element.OnCreate is null)
      {
        element.OnCreate = Utils.Constants.Empty.Actions;
      }
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="DebugLog"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>Answer_0007</term><description>86b05ac8299b6aa4d981d66648fa72b6</description></item>
    /// <item><term>SW_SeelahDoor_Actions</term><description>ee6f1cc0643a6f94cac31290bd6084b2</description></item>
    /// <item><term>ThresholdIndoor_SecondFloor</term><description>8b1257aca48c59844a85dd1b11e5df7f</description></item>
    /// </list>
    /// </remarks>
    public static ActionsBuilder DebugLog(
        this ActionsBuilder builder,
        bool? breakValue = null,
        string? log = null)
    {
      var element = ElementTool.Create<DebugLog>();
      element.Break = breakValue ?? element.Break;
      element.Log = log ?? element.Log;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="FillSharedVendorTable"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>DungeonRoot</term><description>096f36d4e55b49129ddd2211b2c50513</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="sharedTable">
    /// <para>
    /// InfoBox: We take AddLootToVendorTable and DungeonAddLootToVendor components from the SourceVendor and add goods to the SharedTable
    /// </para>
    /// <para>
    /// Blueprint of type BlueprintSharedVendorTable. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    /// <param name="sourceVendor">
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
    public static ActionsBuilder FillSharedVendorTable(
        this ActionsBuilder builder,
        Blueprint<BlueprintSharedVendorTableReference>? sharedTable = null,
        Blueprint<BlueprintUnitReference>? sourceVendor = null)
    {
      var element = ElementTool.Create<FillSharedVendorTable>();
      element.m_SharedTable = sharedTable?.Reference ?? element.m_SharedTable;
      if (element.m_SharedTable is null)
      {
        element.m_SharedTable = BlueprintTool.GetRef<BlueprintSharedVendorTableReference>(null);
      }
      element.m_SourceVendor = sourceVendor?.Reference ?? element.m_SourceVendor;
      if (element.m_SourceVendor is null)
      {
        element.m_SourceVendor = BlueprintTool.GetRef<BlueprintUnitReference>(null);
      }
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="GameLog"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>CommandAction4</term><description>38c390876850441fa257db790ca21735</description></item>
    /// <item><term>DLC5_WightTriggered_Actions</term><description>b3b3dfcaef8f465c977568cf53913cf5</description></item>
    /// <item><term>LoreReligionUseAbility</term><description>4843cb4c23951f54290c5149a4907f54</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="message">
    /// You can pass in the string using a LocalizedString or the Key to a LocalizedString.
    /// </param>
    public static ActionsBuilder GameLog(
        this ActionsBuilder builder,
        LocalString? message = null)
    {
      var element = ElementTool.Create<GameLog>();
      element.Message = message?.LocalizedString ?? element.Message;
      if (element.Message is null)
      {
        element.Message = Utils.Constants.Empty.String;
      }
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="GameOver"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>CommandAction</term><description>5b9e7c0c242f41ea8c880d260ee29892</description></item>
    /// <item><term>CommandAction2</term><description>9e8e0485f3fb4f7db271ec9ba52e76d5</description></item>
    /// <item><term>Epilogues_afterlogues_dialogue</term><description>57e18f5158904030a84a772fb361ceb4</description></item>
    /// </list>
    /// </remarks>
    public static ActionsBuilder GameOver(
        this ActionsBuilder builder,
        Player.GameOverReasonType? reason = null)
    {
      var element = ElementTool.Create<GameOver>();
      element.Reason = reason ?? element.Reason;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ImportSave"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>c4-c5_interchapter</term><description>09f9a3762723ced47b25f953ddbc9e32</description></item>
    /// <item><term>Cue_0122</term><description>381b44c6ac9e37744b135f7a0ed3c2d8</description></item>
    /// <item><term>ImportDLC5</term><description>f17326931d6a4b6e9423377567eb834d</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="autoImportIfOnlyOneSave">
    /// <para>
    /// Tooltip: Import automatically if only one appropriate save file is presented.
    /// </para>
    /// </param>
    /// <param name="campaign">
    /// <para>
    /// Blueprint of type BlueprintCampaign. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    /// <param name="clearPreviousImport">
    /// <para>
    /// InfoBox: Удаляет упоминание об импорте этого кампейна, но НЕ ОЧИЩАЕТ фактический импорт. Использовать только для починки сломанных сейвов, как в PF-523639. Фактическую очистку импорта можно попробовать сделать отдельными экшонами.
    /// </para>
    /// </param>
    /// <param name="letPlayerChooseSave">
    /// <para>
    /// Tooltip: Display a prompt asking to choose a save from a list, if any. Otherwise the save will be chosen automatically and silently imported.
    /// </para>
    /// </param>
    public static ActionsBuilder ImportSave(
        this ActionsBuilder builder,
        bool? autoImportIfOnlyOneSave = null,
        Blueprint<BlueprintCampaignReference>? campaign = null,
        bool? clearPreviousImport = null,
        bool? letPlayerChooseSave = null,
        bool? notImmediatly = null)
    {
      var element = ElementTool.Create<ImportSave>();
      element.m_AutoImportIfOnlyOneSave = autoImportIfOnlyOneSave ?? element.m_AutoImportIfOnlyOneSave;
      element.m_Campaign = campaign?.Reference ?? element.m_Campaign;
      if (element.m_Campaign is null)
      {
        element.m_Campaign = BlueprintTool.GetRef<BlueprintCampaignReference>(null);
      }
      element.m_ClearPreviousImport = clearPreviousImport ?? element.m_ClearPreviousImport;
      element.m_LetPlayerChooseSave = letPlayerChooseSave ?? element.m_LetPlayerChooseSave;
      element.m_NotImmediatly = notImmediatly ?? element.m_NotImmediatly;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="MakeAutoSave"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>2FinalFight</term><description>5ea3f8cc4a6f6b4498e55456a4980f2d</description></item>
    /// <item><term>Cue_0023</term><description>1748505b610131747ae2f80f2286a19a</description></item>
    /// <item><term>ToRoofs_FromMediumToLower_TeleportFail</term><description>cef19ac4f4194e1cb3ddf53cb2793bbe</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="savedGameStatus">
    /// <para>
    /// InfoBox: Опционально: статус игры на момент сейва для текстового описания
    /// </para>
    /// <para>
    /// Blueprint of type BlueprintSavedGameStatus. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public static ActionsBuilder MakeAutoSave(
        this ActionsBuilder builder,
        bool? askConfirmation = null,
        Blueprint<BlueprintSavedGameStatusReference>? savedGameStatus = null,
        bool? saveForImport = null)
    {
      var element = ElementTool.Create<MakeAutoSave>();
      element.AskConfirmation = askConfirmation ?? element.AskConfirmation;
      element.SavedGameStatus = savedGameStatus?.Reference ?? element.SavedGameStatus;
      if (element.SavedGameStatus is null)
      {
        element.SavedGameStatus = BlueprintTool.GetRef<BlueprintSavedGameStatusReference>(null);
      }
      element.SaveForImport = saveForImport ?? element.SaveForImport;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="MakeItemNonRemovable"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>Answer_0066</term><description>6f7cdaa54e3176f4b8f55cb21faa606c</description></item>
    /// <item><term>Cue_0013</term><description>73f984a6ecfe6d64f87f2045aa92fd84</description></item>
    /// <item><term>Wardstone_BookEvent</term><description>b24b879dad653a74d8105f377f2ab1a1</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="item">
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
    public static ActionsBuilder MakeItemNonRemovable(
        this ActionsBuilder builder,
        Blueprint<BlueprintItemReference>? item = null,
        bool? nonRemovable = null)
    {
      var element = ElementTool.Create<MakeItemNonRemovable>();
      element.m_Item = item?.Reference ?? element.m_Item;
      if (element.m_Item is null)
      {
        element.m_Item = BlueprintTool.GetRef<BlueprintItemReference>(null);
      }
      element.NonRemovable = nonRemovable ?? element.NonRemovable;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="MovePartyItemsAction"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>ColyphyrPrisonersMechanics</term><description>83d837907d526c144938dc0eff156a41</description></item>
    /// <item><term>IvoryLabyrinth_Prison</term><description>f97f4de6a5073df49b9cac68859f05ae</description></item>
    /// <item><term>Prologue_Caves_1_Default_Preset</term><description>816615290645ad44f9b5e142490ebbd6</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="leaveEquipmentOf">
    /// <para>
    /// Tooltip: Do not remove items equipped on some companions
    /// </para>
    /// </param>
    public static ActionsBuilder MovePartyItemsAction(
        this ActionsBuilder builder,
        MovePartyItemsAction.LeaveSettings? leaveEquipmentOf = null,
        MovePartyItemsAction.ItemType? pickupTypes = null,
        ItemsCollectionEvaluator? targetCollection = null)
    {
      var element = ElementTool.Create<MovePartyItemsAction>();
      builder.Validate(leaveEquipmentOf);
      element.m_LeaveEquipmentOf = leaveEquipmentOf ?? element.m_LeaveEquipmentOf;
      element.PickupTypes = pickupTypes ?? element.PickupTypes;
      builder.Validate(targetCollection);
      element.TargetCollection = targetCollection ?? element.TargetCollection;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="OpenSelectMythicUI"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>CheliaxWaitingInRuins</term><description>1fb5dba7e2beabe4ebf631c07559f64d</description></item>
    /// <item><term>CommandAction1</term><description>bb530e9345434933ba412402ca787bf1</description></item>
    /// <item><term>Cue_43</term><description>a859441b3830497dbdbf9782a7059fef</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="afterCommitActions">
    /// <para>
    /// Tooltip: If levelUp was complete
    /// </para>
    /// </param>
    /// <param name="afterStopActions">
    /// <para>
    /// Tooltip: If levelUp was close
    /// </para>
    /// </param>
    /// <param name="lockStopChargen">
    /// <para>
    /// Tooltip: If true, buttons Close, Back and Esc will be disable in chargen
    /// </para>
    /// </param>
    /// <param name="mayLoopLevelUp">
    /// <para>
    /// Tooltip: If need few levelup
    /// </para>
    /// </param>
    public static ActionsBuilder OpenSelectMythicUI(
        this ActionsBuilder builder,
        ActionsBuilder? afterCommitActions = null,
        ActionsBuilder? afterStopActions = null,
        bool? lockStopChargen = null,
        bool? mayLoopLevelUp = null)
    {
      var element = ElementTool.Create<OpenSelectMythicUI>();
      element.m_AfterCommitActions = afterCommitActions?.Build() ?? element.m_AfterCommitActions;
      if (element.m_AfterCommitActions is null)
      {
        element.m_AfterCommitActions = Utils.Constants.Empty.Actions;
      }
      element.m_AfterStopActions = afterStopActions?.Build() ?? element.m_AfterStopActions;
      if (element.m_AfterStopActions is null)
      {
        element.m_AfterStopActions = Utils.Constants.Empty.Actions;
      }
      element.m_LockStopChargen = lockStopChargen ?? element.m_LockStopChargen;
      element.m_MayLoopLevelUp = mayLoopLevelUp ?? element.m_MayLoopLevelUp;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="RemoveItemFromPlayer"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <para>
    /// ComponentName: Actions/RemoveItemFromPlayer
    /// </para>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AcidButton1_CheckPassedActions</term><description>2a969038211346358597f80d271d9b94</description></item>
    /// <item><term>Cue_0033</term><description>5bb030028b6caa34dbb6c1099880146a</description></item>
    /// <item><term>ZeorisDaggerRingProject_Enchanting</term><description>0dc3a4e036064970857b3c3e296a7d94</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="itemToRemove">
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
    public static ActionsBuilder RemoveItemFromPlayer(
        this ActionsBuilder builder,
        Blueprint<BlueprintItemReference>? itemToRemove = null,
        bool? money = null,
        float? percentage = null,
        int? quantity = null,
        bool? removeAll = null,
        bool? silent = null)
    {
      var element = ElementTool.Create<RemoveItemFromPlayer>();
      element.m_ItemToRemove = itemToRemove?.Reference ?? element.m_ItemToRemove;
      if (element.m_ItemToRemove is null)
      {
        element.m_ItemToRemove = BlueprintTool.GetRef<BlueprintItemReference>(null);
      }
      element.Money = money ?? element.Money;
      element.Percentage = percentage ?? element.Percentage;
      element.Quantity = quantity ?? element.Quantity;
      element.RemoveAll = removeAll ?? element.RemoveAll;
      element.m_Silent = silent ?? element.m_Silent;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="RemoveItemsFromCollection"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>Answer_0011</term><description>ac4468a7eded7fd43946f1a730791ff0</description></item>
    /// <item><term>Cue_0094_TrickReinf</term><description>062f826dcda44cb4b9ae5649e95a974e</description></item>
    /// <item><term>RevertYellow</term><description>0aa2618093d44ed7bce51a1fbadddff8</description></item>
    /// </list>
    /// </remarks>
    public static ActionsBuilder RemoveItemsFromCollection(
        this ActionsBuilder builder,
        ItemsCollectionEvaluator? collection = null,
        List<LootEntry>? loot = null,
        RemoveItemsFromCollection.RemoveStrategyType? removeStrategy = null)
    {
      var element = ElementTool.Create<RemoveItemsFromCollection>();
      builder.Validate(collection);
      element.Collection = collection ?? element.Collection;
      builder.Validate(loot);
      element.Loot = loot ?? element.Loot;
      if (element.Loot is null)
      {
        element.Loot = new();
      }
      element.RemoveStrategy = removeStrategy ?? element.RemoveStrategy;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="SellCollectibleItems"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <para>
    /// ComponentName: Actions/SellCollectibleItems
    /// </para>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>Cue_0032</term><description>48be2f65960f7074fbcfb369ea4e75b8</description></item>
    /// <item><term>Cue_0215</term><description>fc8766d2613f86b46b35e965324c09f3</description></item>
    /// <item><term>Cue_0433</term><description>12306a8e04af53a4bad19b07e3e58b77</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="itemToSell">
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
    public static ActionsBuilder SellCollectibleItems(
        this ActionsBuilder builder,
        bool? halfPrice = null,
        Blueprint<BlueprintItemReference>? itemToSell = null)
    {
      var element = ElementTool.Create<SellCollectibleItems>();
      element.HalfPrice = halfPrice ?? element.HalfPrice;
      element.m_ItemToSell = itemToSell?.Reference ?? element.m_ItemToSell;
      if (element.m_ItemToSell is null)
      {
        element.m_ItemToSell = BlueprintTool.GetRef<BlueprintItemReference>(null);
      }
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="SetVendorPriceModifier"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>Answer_0053</term><description>4a39499e080be884b9566f948362f0a1</description></item>
    /// <item><term>DLC3_ShopOverride_Port</term><description>c56faf9cd55245d79f88050d1146ef9e</description></item>
    /// <item><term>Vendor_Tiefling_SetBigPrices</term><description>04e277fd32f342739153f7bd6d2919a9</description></item>
    /// </list>
    /// </remarks>
    public static ActionsBuilder SetVendorPriceModifier(
        this ActionsBuilder builder,
        SetVendorPriceModifier.Entry[]? entries = null,
        UnitEvaluator? vendorUnit = null)
    {
      var element = ElementTool.Create<SetVendorPriceModifier>();
      builder.Validate(entries);
      element.m_Entries = entries ?? element.m_Entries;
      if (element.m_Entries is null)
      {
        element.m_Entries = new SetVendorPriceModifier.Entry[0];
      }
      builder.Validate(vendorUnit);
      element.VendorUnit = vendorUnit ?? element.VendorUnit;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ShowNewTutorial"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>Alushinyrra_FlyingIsles_HigherCityTutorial</term><description>703a58daf08849d9bb67e328064866ea</description></item>
    /// <item><term>DangerousMonsterTutorial_2</term><description>8ee66977e7c1417face00c91d458498f</description></item>
    /// <item><term>TutorInspect</term><description>8edce8ffe87051a4eb32293277f7b4be</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="tutorial">
    /// <para>
    /// Blueprint of type BlueprintTutorial. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public static ActionsBuilder ShowNewTutorial(
        this ActionsBuilder builder,
        TutorialContextDataEvaluator[]? evaluators = null,
        Blueprint<BlueprintTutorial.Reference>? tutorial = null)
    {
      var element = ElementTool.Create<ShowNewTutorial>();
      builder.Validate(evaluators);
      element.Evaluators = evaluators ?? element.Evaluators;
      if (element.Evaluators is null)
      {
        element.Evaluators = new TutorialContextDataEvaluator[0];
      }
      element.m_Tutorial = tutorial?.Reference ?? element.m_Tutorial;
      if (element.m_Tutorial is null)
      {
        element.m_Tutorial = BlueprintTool.GetRef<BlueprintTutorial.Reference>(null);
      }
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="ShowPartySelection"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>Answer_0005</term><description>daab00a6e6c650246a7ebb32c9fd8240</description></item>
    /// <item><term>DLC1_ThresholdOutdoor_BET_MixedFar</term><description>a5dca28200034f298e04270b0aed3d5d</description></item>
    /// <item><term>ZigguratNoMoreLichTransition</term><description>857ac3ee06be46688c1040033fd2224a</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="forceCapitalModeLogic">
    /// <para>
    /// InfoBox: Group selector logic will be similar to Hub exit (all remote companions will be accessible)
    /// </para>
    /// </param>
    public static ActionsBuilder ShowPartySelection(
        this ActionsBuilder builder,
        ActionsBuilder? actionsAfterPartySelection = null,
        ActionsBuilder? actionsIfCanceled = null,
        bool? forceCapitalModeLogic = null)
    {
      var element = ElementTool.Create<ShowPartySelection>();
      element.ActionsAfterPartySelection = actionsAfterPartySelection?.Build() ?? element.ActionsAfterPartySelection;
      if (element.ActionsAfterPartySelection is null)
      {
        element.ActionsAfterPartySelection = Utils.Constants.Empty.Actions;
      }
      element.ActionsIfCanceled = actionsIfCanceled?.Build() ?? element.ActionsIfCanceled;
      if (element.ActionsIfCanceled is null)
      {
        element.ActionsIfCanceled = Utils.Constants.Empty.Actions;
      }
      element.ForceCapitalModeLogic = forceCapitalModeLogic ?? element.ForceCapitalModeLogic;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="StartTrade"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>Answer_0001</term><description>32346e6ee58b4139a2bbabab80317c28</description></item>
    /// <item><term>Cue_0007</term><description>b5745ab9578437c468acbea59d33f5fb</description></item>
    /// <item><term>WoljifFarewell_dialogue</term><description>0e94cfa04d06db1438eb565f60c0012c</description></item>
    /// </list>
    /// </remarks>
    public static ActionsBuilder StartTrade(
        this ActionsBuilder builder,
        UnitEvaluator? vendor = null)
    {
      var element = ElementTool.Create<StartTrade>();
      builder.Validate(vendor);
      element.Vendor = vendor ?? element.Vendor;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="UnequipAllItems"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>CamelliaQ2</term><description>ab6e8c0132ddd2a4495408cfacb660f7</description></item>
    /// <item><term>CommandAction7</term><description>21e12a3472654797a96aa5b780fb29b9</description></item>
    /// <item><term>LannWantsTraining_Sparring</term><description>35d585854f8cfa84491a58e49642d4c0</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="destinationContainer">
    /// <para>
    /// InfoBox: If not specified, items will be moved to unit&amp;apos;s inventory
    /// </para>
    /// </param>
    public static ActionsBuilder UnequipAllItems(
        this ActionsBuilder builder,
        ItemsCollectionEvaluator? destinationContainer = null,
        bool? silent = null,
        UnitEvaluator? target = null)
    {
      var element = ElementTool.Create<UnequipAllItems>();
      builder.Validate(destinationContainer);
      element.DestinationContainer = destinationContainer ?? element.DestinationContainer;
      element.Silent = silent ?? element.Silent;
      builder.Validate(target);
      element.Target = target ?? element.Target;
      return builder.Add(element);
    }

    /// <summary>
    /// Adds <see cref="UnequipItem"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>Answer_0002</term><description>6ced3f48dbdf44b2aa3e526a755f994e</description></item>
    /// <item><term>Cue_0051</term><description>3df7adbce79f77f41a2830ac44b85591</description></item>
    /// <item><term>LivingGrimoireHolyBookBuffSecondary</term><description>0688ae60216d4356b46b8a71338b7b88</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="destinationContainer">
    /// <para>
    /// InfoBox: If not specified, item will be moved to unit&amp;apos;s inventory
    /// </para>
    /// </param>
    /// <param name="item">
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
    public static ActionsBuilder UnequipItem(
        this ActionsBuilder builder,
        bool? all = null,
        ItemsCollectionEvaluator? destinationContainer = null,
        Blueprint<BlueprintItemReference>? item = null,
        bool? silent = null,
        EquipSlotType? slotType = null,
        UnequipItem.TargetTypeValues? targetType = null,
        UnitEvaluator? unit = null)
    {
      var element = ElementTool.Create<UnequipItem>();
      element.All = all ?? element.All;
      builder.Validate(destinationContainer);
      element.DestinationContainer = destinationContainer ?? element.DestinationContainer;
      element.m_Item = item?.Reference ?? element.m_Item;
      if (element.m_Item is null)
      {
        element.m_Item = BlueprintTool.GetRef<BlueprintItemReference>(null);
      }
      element.Silent = silent ?? element.Silent;
      element.SlotType = slotType ?? element.SlotType;
      element.TargetType = targetType ?? element.TargetType;
      builder.Validate(unit);
      element.Unit = unit ?? element.Unit;
      return builder.Add(element);
    }
  }
}

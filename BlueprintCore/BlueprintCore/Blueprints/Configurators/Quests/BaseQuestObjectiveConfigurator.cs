//***** AUTO-GENERATED - DO NOT EDIT *****//

using BlueprintCore.Actions.Builder;
using BlueprintCore.Blueprints.Configurators.Facts;
using BlueprintCore.Blueprints.CustomConfigurators;
using BlueprintCore.Conditions.Builder;
using BlueprintCore.Utils;
using Kingmaker.AreaLogic.QuestSystem;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Area;
using Kingmaker.Blueprints.Classes.Experience;
using Kingmaker.Blueprints.Quests;
using Kingmaker.Designers.EventConditionActionSystem.ObjectiveEvents;
using Kingmaker.ElementsSystem;
using Kingmaker.Globalmap.Blueprints;
using Kingmaker.Localization;
using Kingmaker.Utility;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlueprintCore.Blueprints.Configurators.Quests
{
  /// <summary>
  /// Implements common fields and components for blueprints inheriting from <see cref="BlueprintQuestObjective"/>.
  /// </summary>
  /// <inheritdoc/>
  public abstract class BaseQuestObjectiveConfigurator<T, TBuilder>
    : BaseFactConfigurator<T, TBuilder>
    where T : BlueprintQuestObjective
    where TBuilder : BaseQuestObjectiveConfigurator<T, TBuilder>
  {
    protected BaseQuestObjectiveConfigurator(Blueprint<BlueprintReference<T>> blueprint) : base(blueprint) { }

    /// <inheritdoc cref="RootConfigurator{T, TBuilder}.CopyFrom(Blueprint{BlueprintReference{BlueprintScriptableObject}}, Type[])"/>
    public TBuilder CopyFrom(
      Blueprint<BlueprintReference<BlueprintQuestObjective>> blueprint, params Type[] componentTypes)
    {
      base.CopyFrom(blueprint.ToString(), componentTypes);
    
      return OnConfigureInternal(
        bp =>
        {
          var copyFrom = blueprint.Reference.Get();
          bp.m_Addendums = copyFrom.m_Addendums;
          bp.m_Areas = copyFrom.m_Areas;
          bp.Title = copyFrom.Title;
          bp.Locations = copyFrom.Locations;
          bp.MultiEntranceEntries = copyFrom.MultiEntranceEntries;
          bp.Description = copyFrom.Description;
          bp.AutoFailDays = copyFrom.AutoFailDays;
          bp.IsFakeFail = copyFrom.IsFakeFail;
          bp.StartOnKingdomTime = copyFrom.StartOnKingdomTime;
          bp.m_FinishParent = copyFrom.m_FinishParent;
          bp.m_Hidden = copyFrom.m_Hidden;
          bp.m_NextObjectives = copyFrom.m_NextObjectives;
          bp.m_Quest = copyFrom.m_Quest;
          bp.m_Type = copyFrom.m_Type;
        });
    }

    /// <inheritdoc cref="RootConfigurator{T, TBuilder}.CopyFrom(Blueprint{BlueprintReference{BlueprintScriptableObject}}, Predicate{BlueprintComponent})"/>
    public TBuilder CopyFrom(
      Blueprint<BlueprintReference<BlueprintQuestObjective>> blueprint, Predicate<BlueprintComponent> componentMatcher)
    {
      base.CopyFrom(blueprint.ToString(), componentMatcher);
    
      return OnConfigureInternal(
        bp =>
        {
          var copyFrom = blueprint.Reference.Get();
          bp.m_Addendums = copyFrom.m_Addendums;
          bp.m_Areas = copyFrom.m_Areas;
          bp.Title = copyFrom.Title;
          bp.Locations = copyFrom.Locations;
          bp.MultiEntranceEntries = copyFrom.MultiEntranceEntries;
          bp.Description = copyFrom.Description;
          bp.AutoFailDays = copyFrom.AutoFailDays;
          bp.IsFakeFail = copyFrom.IsFakeFail;
          bp.StartOnKingdomTime = copyFrom.StartOnKingdomTime;
          bp.m_FinishParent = copyFrom.m_FinishParent;
          bp.m_Hidden = copyFrom.m_Hidden;
          bp.m_NextObjectives = copyFrom.m_NextObjectives;
          bp.m_Quest = copyFrom.m_Quest;
          bp.m_Type = copyFrom.m_Type;
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintQuestObjective.m_Addendums"/>
    /// </summary>
    ///
    /// <param name="addendums">
    /// <para>
    /// Blueprint of type BlueprintQuestObjective. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder SetAddendums(params Blueprint<BlueprintQuestObjectiveReference>[] addendums)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_Addendums = addendums.Select(bp => bp.Reference).ToList();
        });
    }

    /// <summary>
    /// Adds to the contents of <see cref="BlueprintQuestObjective.m_Addendums"/>
    /// </summary>
    ///
    /// <param name="addendums">
    /// <para>
    /// Blueprint of type BlueprintQuestObjective. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder AddToAddendums(params Blueprint<BlueprintQuestObjectiveReference>[] addendums)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_Addendums = bp.m_Addendums ?? new();
          bp.m_Addendums.AddRange(addendums.Select(bp => bp.Reference));
        });
    }

    /// <summary>
    /// Removes elements from <see cref="BlueprintQuestObjective.m_Addendums"/>
    /// </summary>
    ///
    /// <param name="addendums">
    /// <para>
    /// Blueprint of type BlueprintQuestObjective. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder RemoveFromAddendums(params Blueprint<BlueprintQuestObjectiveReference>[] addendums)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.m_Addendums is null) { return; }
          bp.m_Addendums = bp.m_Addendums.Where(val => !addendums.Contains(val)).ToList();
        });
    }

    /// <summary>
    /// Removes elements from <see cref="BlueprintQuestObjective.m_Addendums"/> that match the provided predicate.
    /// </summary>
    public TBuilder RemoveFromAddendums(Func<BlueprintQuestObjectiveReference, bool> predicate)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.m_Addendums is null) { return; }
          bp.m_Addendums = bp.m_Addendums.Where(e => !predicate(e)).ToList();
        });
    }

    /// <summary>
    /// Removes all elements from <see cref="BlueprintQuestObjective.m_Addendums"/>
    /// </summary>
    public TBuilder ClearAddendums()
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_Addendums = new();
        });
    }

    /// <summary>
    /// Modifies <see cref="BlueprintQuestObjective.m_Addendums"/> by invoking the provided action on each element.
    /// </summary>
    public TBuilder ModifyAddendums(Action<BlueprintQuestObjectiveReference> action)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.m_Addendums is null) { return; }
          bp.m_Addendums.ForEach(action);
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintQuestObjective.m_Areas"/>
    /// </summary>
    ///
    /// <param name="areas">
    /// <para>
    /// Blueprint of type BlueprintArea. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder SetAreas(params Blueprint<BlueprintAreaReference>[] areas)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_Areas = areas.Select(bp => bp.Reference).ToList();
        });
    }

    /// <summary>
    /// Adds to the contents of <see cref="BlueprintQuestObjective.m_Areas"/>
    /// </summary>
    ///
    /// <param name="areas">
    /// <para>
    /// Blueprint of type BlueprintArea. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder AddToAreas(params Blueprint<BlueprintAreaReference>[] areas)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_Areas = bp.m_Areas ?? new();
          bp.m_Areas.AddRange(areas.Select(bp => bp.Reference));
        });
    }

    /// <summary>
    /// Removes elements from <see cref="BlueprintQuestObjective.m_Areas"/>
    /// </summary>
    ///
    /// <param name="areas">
    /// <para>
    /// Blueprint of type BlueprintArea. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder RemoveFromAreas(params Blueprint<BlueprintAreaReference>[] areas)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.m_Areas is null) { return; }
          bp.m_Areas = bp.m_Areas.Where(val => !areas.Contains(val)).ToList();
        });
    }

    /// <summary>
    /// Removes elements from <see cref="BlueprintQuestObjective.m_Areas"/> that match the provided predicate.
    /// </summary>
    public TBuilder RemoveFromAreas(Func<BlueprintAreaReference, bool> predicate)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.m_Areas is null) { return; }
          bp.m_Areas = bp.m_Areas.Where(e => !predicate(e)).ToList();
        });
    }

    /// <summary>
    /// Removes all elements from <see cref="BlueprintQuestObjective.m_Areas"/>
    /// </summary>
    public TBuilder ClearAreas()
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_Areas = new();
        });
    }

    /// <summary>
    /// Modifies <see cref="BlueprintQuestObjective.m_Areas"/> by invoking the provided action on each element.
    /// </summary>
    public TBuilder ModifyAreas(Action<BlueprintAreaReference> action)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.m_Areas is null) { return; }
          bp.m_Areas.ForEach(action);
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintQuestObjective.Title"/>
    /// </summary>
    ///
    /// <param name="title">
    /// You can pass in the string using a LocalizedString or the Key to a LocalizedString.
    /// </param>
    public TBuilder SetTitle(LocalString title)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.Title = title?.LocalizedString;
        });
    }

    /// <summary>
    /// Modifies <see cref="BlueprintQuestObjective.Title"/> by invoking the provided action.
    /// </summary>
    public TBuilder ModifyTitle(Action<LocalizedString> action)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.Title is null) { return; }
          action.Invoke(bp.Title);
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintQuestObjective.Locations"/>
    /// </summary>
    ///
    /// <param name="locations">
    /// <para>
    /// Blueprint of type BlueprintGlobalMapPoint. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder SetLocations(params Blueprint<BlueprintGlobalMapPoint.Reference>[] locations)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.Locations = locations.Select(bp => bp.Reference).ToList();
        });
    }

    /// <summary>
    /// Adds to the contents of <see cref="BlueprintQuestObjective.Locations"/>
    /// </summary>
    ///
    /// <param name="locations">
    /// <para>
    /// Blueprint of type BlueprintGlobalMapPoint. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder AddToLocations(params Blueprint<BlueprintGlobalMapPoint.Reference>[] locations)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.Locations = bp.Locations ?? new();
          bp.Locations.AddRange(locations.Select(bp => bp.Reference));
        });
    }

    /// <summary>
    /// Removes elements from <see cref="BlueprintQuestObjective.Locations"/>
    /// </summary>
    ///
    /// <param name="locations">
    /// <para>
    /// Blueprint of type BlueprintGlobalMapPoint. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder RemoveFromLocations(params Blueprint<BlueprintGlobalMapPoint.Reference>[] locations)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.Locations is null) { return; }
          bp.Locations = bp.Locations.Where(val => !locations.Contains(val)).ToList();
        });
    }

    /// <summary>
    /// Removes elements from <see cref="BlueprintQuestObjective.Locations"/> that match the provided predicate.
    /// </summary>
    public TBuilder RemoveFromLocations(Func<BlueprintGlobalMapPoint.Reference, bool> predicate)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.Locations is null) { return; }
          bp.Locations = bp.Locations.Where(e => !predicate(e)).ToList();
        });
    }

    /// <summary>
    /// Removes all elements from <see cref="BlueprintQuestObjective.Locations"/>
    /// </summary>
    public TBuilder ClearLocations()
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.Locations = new();
        });
    }

    /// <summary>
    /// Modifies <see cref="BlueprintQuestObjective.Locations"/> by invoking the provided action on each element.
    /// </summary>
    public TBuilder ModifyLocations(Action<BlueprintGlobalMapPoint.Reference> action)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.Locations is null) { return; }
          bp.Locations.ForEach(action);
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintQuestObjective.MultiEntranceEntries"/>
    /// </summary>
    ///
    /// <param name="multiEntranceEntries">
    /// <para>
    /// Blueprint of type BlueprintMultiEntranceEntry. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder SetMultiEntranceEntries(params Blueprint<BlueprintMultiEntranceEntry.Reference>[] multiEntranceEntries)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.MultiEntranceEntries = multiEntranceEntries.Select(bp => bp.Reference).ToList();
        });
    }

    /// <summary>
    /// Adds to the contents of <see cref="BlueprintQuestObjective.MultiEntranceEntries"/>
    /// </summary>
    ///
    /// <param name="multiEntranceEntries">
    /// <para>
    /// Blueprint of type BlueprintMultiEntranceEntry. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder AddToMultiEntranceEntries(params Blueprint<BlueprintMultiEntranceEntry.Reference>[] multiEntranceEntries)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.MultiEntranceEntries = bp.MultiEntranceEntries ?? new();
          bp.MultiEntranceEntries.AddRange(multiEntranceEntries.Select(bp => bp.Reference));
        });
    }

    /// <summary>
    /// Removes elements from <see cref="BlueprintQuestObjective.MultiEntranceEntries"/>
    /// </summary>
    ///
    /// <param name="multiEntranceEntries">
    /// <para>
    /// Blueprint of type BlueprintMultiEntranceEntry. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder RemoveFromMultiEntranceEntries(params Blueprint<BlueprintMultiEntranceEntry.Reference>[] multiEntranceEntries)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.MultiEntranceEntries is null) { return; }
          bp.MultiEntranceEntries = bp.MultiEntranceEntries.Where(val => !multiEntranceEntries.Contains(val)).ToList();
        });
    }

    /// <summary>
    /// Removes elements from <see cref="BlueprintQuestObjective.MultiEntranceEntries"/> that match the provided predicate.
    /// </summary>
    public TBuilder RemoveFromMultiEntranceEntries(Func<BlueprintMultiEntranceEntry.Reference, bool> predicate)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.MultiEntranceEntries is null) { return; }
          bp.MultiEntranceEntries = bp.MultiEntranceEntries.Where(e => !predicate(e)).ToList();
        });
    }

    /// <summary>
    /// Removes all elements from <see cref="BlueprintQuestObjective.MultiEntranceEntries"/>
    /// </summary>
    public TBuilder ClearMultiEntranceEntries()
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.MultiEntranceEntries = new();
        });
    }

    /// <summary>
    /// Modifies <see cref="BlueprintQuestObjective.MultiEntranceEntries"/> by invoking the provided action on each element.
    /// </summary>
    public TBuilder ModifyMultiEntranceEntries(Action<BlueprintMultiEntranceEntry.Reference> action)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.MultiEntranceEntries is null) { return; }
          bp.MultiEntranceEntries.ForEach(action);
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintQuestObjective.Description"/>
    /// </summary>
    ///
    /// <param name="description">
    /// You can pass in the string using a LocalizedString or the Key to a LocalizedString.
    /// </param>
    public TBuilder SetDescription(LocalString description)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.Description = description?.LocalizedString;
        });
    }

    /// <summary>
    /// Modifies <see cref="BlueprintQuestObjective.Description"/> by invoking the provided action.
    /// </summary>
    public TBuilder ModifyDescription(Action<LocalizedString> action)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.Description is null) { return; }
          action.Invoke(bp.Description);
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintQuestObjective.AutoFailDays"/>
    /// </summary>
    public TBuilder SetAutoFailDays(int autoFailDays)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.AutoFailDays = autoFailDays;
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintQuestObjective.IsFakeFail"/>
    /// </summary>
    public TBuilder SetIsFakeFail(bool isFakeFail = true)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.IsFakeFail = isFakeFail;
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintQuestObjective.StartOnKingdomTime"/>
    /// </summary>
    public TBuilder SetStartOnKingdomTime(bool startOnKingdomTime = true)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.StartOnKingdomTime = startOnKingdomTime;
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintQuestObjective.m_FinishParent"/>
    /// </summary>
    public TBuilder SetFinishParent(bool finishParent = true)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_FinishParent = finishParent;
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintQuestObjective.m_Hidden"/>
    /// </summary>
    public TBuilder SetHidden(bool hidden = true)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_Hidden = hidden;
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintQuestObjective.m_NextObjectives"/>
    /// </summary>
    ///
    /// <param name="nextObjectives">
    /// <para>
    /// Blueprint of type BlueprintQuestObjective. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder SetNextObjectives(params Blueprint<BlueprintQuestObjectiveReference>[] nextObjectives)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_NextObjectives = nextObjectives.Select(bp => bp.Reference).ToList();
        });
    }

    /// <summary>
    /// Adds to the contents of <see cref="BlueprintQuestObjective.m_NextObjectives"/>
    /// </summary>
    ///
    /// <param name="nextObjectives">
    /// <para>
    /// Blueprint of type BlueprintQuestObjective. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder AddToNextObjectives(params Blueprint<BlueprintQuestObjectiveReference>[] nextObjectives)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_NextObjectives = bp.m_NextObjectives ?? new();
          bp.m_NextObjectives.AddRange(nextObjectives.Select(bp => bp.Reference));
        });
    }

    /// <summary>
    /// Removes elements from <see cref="BlueprintQuestObjective.m_NextObjectives"/>
    /// </summary>
    ///
    /// <param name="nextObjectives">
    /// <para>
    /// Blueprint of type BlueprintQuestObjective. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder RemoveFromNextObjectives(params Blueprint<BlueprintQuestObjectiveReference>[] nextObjectives)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.m_NextObjectives is null) { return; }
          bp.m_NextObjectives = bp.m_NextObjectives.Where(val => !nextObjectives.Contains(val)).ToList();
        });
    }

    /// <summary>
    /// Removes elements from <see cref="BlueprintQuestObjective.m_NextObjectives"/> that match the provided predicate.
    /// </summary>
    public TBuilder RemoveFromNextObjectives(Func<BlueprintQuestObjectiveReference, bool> predicate)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.m_NextObjectives is null) { return; }
          bp.m_NextObjectives = bp.m_NextObjectives.Where(e => !predicate(e)).ToList();
        });
    }

    /// <summary>
    /// Removes all elements from <see cref="BlueprintQuestObjective.m_NextObjectives"/>
    /// </summary>
    public TBuilder ClearNextObjectives()
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_NextObjectives = new();
        });
    }

    /// <summary>
    /// Modifies <see cref="BlueprintQuestObjective.m_NextObjectives"/> by invoking the provided action on each element.
    /// </summary>
    public TBuilder ModifyNextObjectives(Action<BlueprintQuestObjectiveReference> action)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.m_NextObjectives is null) { return; }
          bp.m_NextObjectives.ForEach(action);
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintQuestObjective.m_Quest"/>
    /// </summary>
    ///
    /// <param name="quest">
    /// <para>
    /// Blueprint of type BlueprintQuest. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder SetQuest(Blueprint<BlueprintQuestReference> quest)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_Quest = quest?.Reference;
        });
    }

    /// <summary>
    /// Modifies <see cref="BlueprintQuestObjective.m_Quest"/> by invoking the provided action.
    /// </summary>
    public TBuilder ModifyQuest(Action<BlueprintQuestReference> action)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.m_Quest is null) { return; }
          action.Invoke(bp.m_Quest);
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintQuestObjective.m_Type"/>
    /// </summary>
    public TBuilder SetType(BlueprintQuestObjective.Type type)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_Type = type;
        });
    }

    /// <summary>
    /// Adds <see cref="Experience"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>00_FindEchoLair</term><description>876fc5d40aa5d8b47ac0138cf0a680ae</description></item>
    /// <item><term>DLC3_CR16_FaerieDragonHungryMagicSummon</term><description>1f238fcbd1bb41cfbc35729a2d7c0d2c</description></item>
    /// <item><term>Ziforian_normal</term><description>7ef2998dbeb7fda43a47ce842f4d142d</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    /// <param name="playerGainsNoExp">
    /// <para>
    /// InfoBox: When true, Exp will be used in encounter CR calculation, but player will not gained it
    /// </para>
    /// </param>
    public TBuilder AddExperience(
        IntEvaluator? count = null,
        int? cR = null,
        bool? dummy = null,
        EncounterType? encounter = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail,
        float? modifier = null,
        bool? playerGainsNoExp = null)
    {
      var component = new Experience();
      Validate(count);
      component.Count = count ?? component.Count;
      component.CR = cR ?? component.CR;
      component.Dummy = dummy ?? component.Dummy;
      component.Encounter = encounter ?? component.Encounter;
      component.Modifier = modifier ?? component.Modifier;
      component.PlayerGainsNoExp = playerGainsNoExp ?? component.PlayerGainsNoExp;
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    /// <summary>
    /// Adds <see cref="ObjectiveStatusTrigger"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <para>
    /// ComponentName: Events/ObjectiveStatusTrigger
    /// </para>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>01_GoToCamp</term><description>10d044829fd19a54eb85cae569fc009f</description></item>
    /// <item><term>Obj_hiddenComplete</term><description>30c371a93fdbf0045a10dfa84ff8e1c8</description></item>
    /// <item><term>Step_2</term><description>5a38140285b24b1c96631d1a224d383b</description></item>
    /// </list>
    /// </remarks>
    public TBuilder AddObjectiveStatusTrigger(
        ActionsBuilder? actions = null,
        ConditionsBuilder? conditions = null,
        QuestObjectiveState? objectiveState = null)
    {
      var component = new ObjectiveStatusTrigger();
      component.Actions = actions?.Build() ?? component.Actions;
      if (component.Actions is null)
      {
        component.Actions = Utils.Constants.Empty.Actions;
      }
      component.Conditions = conditions?.Build() ?? component.Conditions;
      if (component.Conditions is null)
      {
        component.Conditions = Utils.Constants.Empty.Conditions;
      }
      component.objectiveState = objectiveState ?? component.objectiveState;
      return AddComponent(component);
    }

    protected override void OnConfigureCompleted()
    {
      base.OnConfigureCompleted();
    
      if (Blueprint.m_Addendums is null)
      {
        Blueprint.m_Addendums = new();
      }
      if (Blueprint.m_Areas is null)
      {
        Blueprint.m_Areas = new();
      }
      if (Blueprint.Title is null)
      {
        Blueprint.Title = Utils.Constants.Empty.String;
      }
      if (Blueprint.Locations is null)
      {
        Blueprint.Locations = new();
      }
      if (Blueprint.MultiEntranceEntries is null)
      {
        Blueprint.MultiEntranceEntries = new();
      }
      if (Blueprint.Description is null)
      {
        Blueprint.Description = Utils.Constants.Empty.String;
      }
      if (Blueprint.m_NextObjectives is null)
      {
        Blueprint.m_NextObjectives = new();
      }
      if (Blueprint.m_Quest is null)
      {
        Blueprint.m_Quest = BlueprintTool.GetRef<BlueprintQuestReference>(null);
      }
    }
  }
}

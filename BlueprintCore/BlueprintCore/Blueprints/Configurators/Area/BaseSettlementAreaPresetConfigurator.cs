//***** AUTO-GENERATED - DO NOT EDIT *****//

using BlueprintCore.Blueprints.Configurators.Area;
using BlueprintCore.Blueprints.CustomConfigurators;
using BlueprintCore.Utils;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Area;
using Kingmaker.Globalmap.Blueprints;
using Kingmaker.Kingdom;
using Kingmaker.Kingdom.Settlements;
using Kingmaker.Utility;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlueprintCore.Blueprints.Configurators.Area
{
  /// <summary>
  /// Implements common fields and components for blueprints inheriting from <see cref="BlueprintSettlementAreaPreset"/>.
  /// </summary>
  /// <inheritdoc/>
  public abstract class BaseSettlementAreaPresetConfigurator<T, TBuilder>
    : BaseAreaPresetConfigurator<T, TBuilder>
    where T : BlueprintSettlementAreaPreset
    where TBuilder : BaseSettlementAreaPresetConfigurator<T, TBuilder>
  {
    protected BaseSettlementAreaPresetConfigurator(Blueprint<BlueprintReference<T>> blueprint) : base(blueprint) { }

    /// <inheritdoc cref="RootConfigurator{T, TBuilder}.CopyFrom(Blueprint{BlueprintReference{BlueprintScriptableObject}}, Type[])"/>
    public TBuilder CopyFrom(
      Blueprint<BlueprintReference<BlueprintSettlementAreaPreset>> blueprint, params Type[] componentTypes)
    {
      base.CopyFrom(blueprint.ToString(), componentTypes);
    
      return OnConfigureInternal(
        bp =>
        {
          var copyFrom = blueprint.Reference.Get();
          bp.m_StartSettlement = copyFrom.m_StartSettlement;
          bp.m_StartSettlementPoint = copyFrom.m_StartSettlementPoint;
          bp.m_StartSettlementLevel = copyFrom.m_StartSettlementLevel;
        });
    }

    /// <inheritdoc cref="RootConfigurator{T, TBuilder}.CopyFrom(Blueprint{BlueprintReference{BlueprintScriptableObject}}, Predicate{BlueprintComponent})"/>
    public TBuilder CopyFrom(
      Blueprint<BlueprintReference<BlueprintSettlementAreaPreset>> blueprint, Predicate<BlueprintComponent> componentMatcher)
    {
      base.CopyFrom(blueprint.ToString(), componentMatcher);
    
      return OnConfigureInternal(
        bp =>
        {
          var copyFrom = blueprint.Reference.Get();
          bp.m_StartSettlement = copyFrom.m_StartSettlement;
          bp.m_StartSettlementPoint = copyFrom.m_StartSettlementPoint;
          bp.m_StartSettlementLevel = copyFrom.m_StartSettlementLevel;
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintSettlementAreaPreset.m_StartSettlement"/>
    /// </summary>
    ///
    /// <param name="startSettlement">
    /// <para>
    /// Blueprint of type BlueprintSettlement. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder SetStartSettlement(Blueprint<BlueprintSettlement.Reference> startSettlement)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_StartSettlement = startSettlement?.Reference;
        });
    }

    /// <summary>
    /// Modifies <see cref="BlueprintSettlementAreaPreset.m_StartSettlement"/> by invoking the provided action.
    /// </summary>
    public TBuilder ModifyStartSettlement(Action<BlueprintSettlement.Reference> action)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.m_StartSettlement is null) { return; }
          action.Invoke(bp.m_StartSettlement);
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintSettlementAreaPreset.m_StartSettlementPoint"/>
    /// </summary>
    ///
    /// <param name="startSettlementPoint">
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
    public TBuilder SetStartSettlementPoint(Blueprint<BlueprintGlobalMapPointReference> startSettlementPoint)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_StartSettlementPoint = startSettlementPoint?.Reference;
        });
    }

    /// <summary>
    /// Modifies <see cref="BlueprintSettlementAreaPreset.m_StartSettlementPoint"/> by invoking the provided action.
    /// </summary>
    public TBuilder ModifyStartSettlementPoint(Action<BlueprintGlobalMapPointReference> action)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.m_StartSettlementPoint is null) { return; }
          action.Invoke(bp.m_StartSettlementPoint);
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintSettlementAreaPreset.m_StartSettlementLevel"/>
    /// </summary>
    public TBuilder SetStartSettlementLevel(SettlementState.LevelType startSettlementLevel)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_StartSettlementLevel = startSettlementLevel;
        });
    }

    protected override void OnConfigureCompleted()
    {
      base.OnConfigureCompleted();
    
      if (Blueprint.m_StartSettlement is null)
      {
        Blueprint.m_StartSettlement = BlueprintTool.GetRef<BlueprintSettlement.Reference>(null);
      }
      if (Blueprint.m_StartSettlementPoint is null)
      {
        Blueprint.m_StartSettlementPoint = BlueprintTool.GetRef<BlueprintGlobalMapPointReference>(null);
      }
    }
  }
}

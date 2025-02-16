//***** AUTO-GENERATED - DO NOT EDIT *****//

using BlueprintCore.Blueprints.Configurators;
using BlueprintCore.Blueprints.CustomConfigurators;
using BlueprintCore.Utils;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Footrprints;
using Kingmaker.Enums;
using Kingmaker.Utility;
using Kingmaker.Utility.EnumArrays;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlueprintCore.Blueprints.Configurators.Footrprints
{
  /// <summary>
  /// Implements common fields and components for blueprints inheriting from <see cref="BlueprintFootprintType"/>.
  /// </summary>
  /// <inheritdoc/>
  public abstract class BaseFootprintTypeConfigurator<T, TBuilder>
    : BaseBlueprintConfigurator<T, TBuilder>
    where T : BlueprintFootprintType
    where TBuilder : BaseFootprintTypeConfigurator<T, TBuilder>
  {
    protected BaseFootprintTypeConfigurator(Blueprint<BlueprintReference<T>> blueprint) : base(blueprint) { }

    /// <inheritdoc cref="RootConfigurator{T, TBuilder}.CopyFrom(Blueprint{BlueprintReference{BlueprintScriptableObject}}, Type[])"/>
    public TBuilder CopyFrom(
      Blueprint<BlueprintReference<BlueprintFootprintType>> blueprint, params Type[] componentTypes)
    {
      base.CopyFrom(blueprint.ToString(), componentTypes);
    
      return OnConfigureInternal(
        bp =>
        {
          var copyFrom = blueprint.Reference.Get();
          bp.FootprintType = copyFrom.FootprintType;
          bp.Footprints = copyFrom.Footprints;
        });
    }

    /// <inheritdoc cref="RootConfigurator{T, TBuilder}.CopyFrom(Blueprint{BlueprintReference{BlueprintScriptableObject}}, Predicate{BlueprintComponent})"/>
    public TBuilder CopyFrom(
      Blueprint<BlueprintReference<BlueprintFootprintType>> blueprint, Predicate<BlueprintComponent> componentMatcher)
    {
      base.CopyFrom(blueprint.ToString(), componentMatcher);
    
      return OnConfigureInternal(
        bp =>
        {
          var copyFrom = blueprint.Reference.Get();
          bp.FootprintType = copyFrom.FootprintType;
          bp.Footprints = copyFrom.Footprints;
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintFootprintType.FootprintType"/>
    /// </summary>
    public TBuilder SetFootprintType(FootprintType footprintType)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.FootprintType = footprintType;
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintFootprintType.Footprints"/>
    /// </summary>
    public TBuilder SetFootprints(FootprintsEnumArray footprints)
    {
      return OnConfigureInternal(
        bp =>
        {
          Validate(footprints);
          bp.Footprints = footprints;
        });
    }

    /// <summary>
    /// Modifies <see cref="BlueprintFootprintType.Footprints"/> by invoking the provided action.
    /// </summary>
    public TBuilder ModifyFootprints(Action<FootprintsEnumArray> action)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.Footprints is null) { return; }
          action.Invoke(bp.Footprints);
        });
    }
  }
}

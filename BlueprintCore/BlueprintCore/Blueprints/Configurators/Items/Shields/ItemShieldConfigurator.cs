//***** AUTO-GENERATED - DO NOT EDIT *****//

using BlueprintCore.Blueprints.Configurators.Items.Shields;
using BlueprintCore.Blueprints.CustomConfigurators;
using BlueprintCore.Utils;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Items.Shields;
using System;

namespace BlueprintCore.Blueprints.Configurators.Items.Shields
{
  /// <summary>
  /// Configurator for <see cref="BlueprintItemShield"/>.
  /// </summary>
  /// <inheritdoc/>
  public class ItemShieldConfigurator
    : BaseItemShieldConfigurator<BlueprintItemShield, ItemShieldConfigurator>
  {
    private ItemShieldConfigurator(Blueprint<BlueprintReference<BlueprintItemShield>> blueprint) : base(blueprint) { }

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
    public static ItemShieldConfigurator For(Blueprint<BlueprintReference<BlueprintItemShield>> blueprint)
    {
      return new ItemShieldConfigurator(blueprint);
    }
    /// <summary>
    /// Creates a new blueprint and returns a new configurator to modify it.
    /// </summary>
    /// <remarks>
    /// <para>
    /// After creating a blueprint with this method you can use either name or GUID to reference the blueprint in BlueprintCore API calls.
    /// </para>
    /// <para>
    /// An implicit cast converts the string to <see cref="Utils.Blueprint{TRef}"/>, exposing the blueprint instance and its reference.
    /// </para>
    /// </remarks>
    public static ItemShieldConfigurator New(string name, string guid)
    {
      BlueprintTool.Create<BlueprintItemShield>(name, guid);
      return For(name);
    }


    /// <inheritdoc cref="RootConfigurator{T, TBuilder}.CopyFrom(Blueprint{BlueprintReference{BlueprintScriptableObject}}, Type[])"/>
    public ItemShieldConfigurator CopyFrom(
      Blueprint<BlueprintReference<BlueprintItemShield>> blueprint, params Type[] componentTypes)
    {
      base.CopyFrom(blueprint.ToString(), componentTypes);
    return Self;
    }

    /// <inheritdoc cref="RootConfigurator{T, TBuilder}.CopyFrom(Blueprint{BlueprintReference{BlueprintScriptableObject}}, Predicate{BlueprintComponent})"/>
    public ItemShieldConfigurator CopyFrom(
      Blueprint<BlueprintReference<BlueprintItemShield>> blueprint, Predicate<BlueprintComponent> componentMatcher)
    {
      base.CopyFrom(blueprint.ToString(), componentMatcher);
    return Self;
    }
  }
}

//***** AUTO-GENERATED - DO NOT EDIT *****//

using BlueprintCore.Blueprints.Configurators.Quests;
using BlueprintCore.Blueprints.CustomConfigurators;
using BlueprintCore.Utils;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Quests;
using System;

namespace BlueprintCore.Blueprints.Configurators.Quests
{
  /// <summary>
  /// Configurator for <see cref="BlueprintQuestGroups"/>.
  /// </summary>
  /// <inheritdoc/>
  public class QuestGroupsConfigurator
    : BaseQuestGroupsConfigurator<BlueprintQuestGroups, QuestGroupsConfigurator>
  {
    private QuestGroupsConfigurator(Blueprint<BlueprintReference<BlueprintQuestGroups>> blueprint) : base(blueprint) { }

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
    public static QuestGroupsConfigurator For(Blueprint<BlueprintReference<BlueprintQuestGroups>> blueprint)
    {
      return new QuestGroupsConfigurator(blueprint);
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
    public static QuestGroupsConfigurator New(string name, string guid)
    {
      BlueprintTool.Create<BlueprintQuestGroups>(name, guid);
      return For(name);
    }


    /// <inheritdoc cref="RootConfigurator{T, TBuilder}.CopyFrom(Blueprint{BlueprintReference{BlueprintScriptableObject}}, Type[])"/>
    public QuestGroupsConfigurator CopyFrom(
      Blueprint<BlueprintReference<BlueprintQuestGroups>> blueprint, params Type[] componentTypes)
    {
      base.CopyFrom(blueprint.ToString(), componentTypes);
    return Self;
    }

    /// <inheritdoc cref="RootConfigurator{T, TBuilder}.CopyFrom(Blueprint{BlueprintReference{BlueprintScriptableObject}}, Predicate{BlueprintComponent})"/>
    public QuestGroupsConfigurator CopyFrom(
      Blueprint<BlueprintReference<BlueprintQuestGroups>> blueprint, Predicate<BlueprintComponent> componentMatcher)
    {
      base.CopyFrom(blueprint.ToString(), componentMatcher);
    return Self;
    }
  }
}

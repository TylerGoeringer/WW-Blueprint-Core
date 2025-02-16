//***** AUTO-GENERATED - DO NOT EDIT *****//

using BlueprintCore.Blueprints.Configurators;
using BlueprintCore.Blueprints.CustomConfigurators;
using BlueprintCore.Utils;
using Kingmaker.Armies.Blueprints;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Facts;
using Kingmaker.Kingdom.Blueprints;
using Kingmaker.Localization;
using Kingmaker.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace BlueprintCore.Blueprints.Configurators.Armies
{
  /// <summary>
  /// Implements common fields and components for blueprints inheriting from <see cref="MoraleRoot"/>.
  /// </summary>
  /// <inheritdoc/>
  public abstract class BaseMoraleRootConfigurator<T, TBuilder>
    : BaseBlueprintConfigurator<T, TBuilder>
    where T : MoraleRoot
    where TBuilder : BaseMoraleRootConfigurator<T, TBuilder>
  {
    protected BaseMoraleRootConfigurator(Blueprint<BlueprintReference<T>> blueprint) : base(blueprint) { }

    /// <inheritdoc cref="RootConfigurator{T, TBuilder}.CopyFrom(Blueprint{BlueprintReference{BlueprintScriptableObject}}, Type[])"/>
    public TBuilder CopyFrom(
      Blueprint<BlueprintReference<MoraleRoot>> blueprint, params Type[] componentTypes)
    {
      base.CopyFrom(blueprint.ToString(), componentTypes);
    
      return OnConfigureInternal(
        bp =>
        {
          var copyFrom = blueprint.Reference.Get();
          bp.m_MoraleBorder = copyFrom.m_MoraleBorder;
          bp.m_DevineForNegative = copyFrom.m_DevineForNegative;
          bp.m_DevineForPositive = copyFrom.m_DevineForPositive;
          bp.m_NegativeFacts = copyFrom.m_NegativeFacts;
          bp.m_GlobalArmiesMoraleBuff = copyFrom.m_GlobalArmiesMoraleBuff;
          bp.BaseMoraleValue = copyFrom.BaseMoraleValue;
          bp.ArmyEffectOnSquad = copyFrom.ArmyEffectOnSquad;
          bp.UnitNotHaveMorale = copyFrom.UnitNotHaveMorale;
        });
    }

    /// <inheritdoc cref="RootConfigurator{T, TBuilder}.CopyFrom(Blueprint{BlueprintReference{BlueprintScriptableObject}}, Predicate{BlueprintComponent})"/>
    public TBuilder CopyFrom(
      Blueprint<BlueprintReference<MoraleRoot>> blueprint, Predicate<BlueprintComponent> componentMatcher)
    {
      base.CopyFrom(blueprint.ToString(), componentMatcher);
    
      return OnConfigureInternal(
        bp =>
        {
          var copyFrom = blueprint.Reference.Get();
          bp.m_MoraleBorder = copyFrom.m_MoraleBorder;
          bp.m_DevineForNegative = copyFrom.m_DevineForNegative;
          bp.m_DevineForPositive = copyFrom.m_DevineForPositive;
          bp.m_NegativeFacts = copyFrom.m_NegativeFacts;
          bp.m_GlobalArmiesMoraleBuff = copyFrom.m_GlobalArmiesMoraleBuff;
          bp.BaseMoraleValue = copyFrom.BaseMoraleValue;
          bp.ArmyEffectOnSquad = copyFrom.ArmyEffectOnSquad;
          bp.UnitNotHaveMorale = copyFrom.UnitNotHaveMorale;
        });
    }

    /// <summary>
    /// Sets the value of <see cref="MoraleRoot.m_MoraleBorder"/>
    /// </summary>
    public TBuilder SetMoraleBorder(Vector2Int moraleBorder)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_MoraleBorder = moraleBorder;
        });
    }

    /// <summary>
    /// Modifies <see cref="MoraleRoot.m_MoraleBorder"/> by invoking the provided action.
    /// </summary>
    public TBuilder ModifyMoraleBorder(Action<Vector2Int> action)
    {
      return OnConfigureInternal(
        bp =>
        {
          action.Invoke(bp.m_MoraleBorder);
        });
    }

    /// <summary>
    /// Sets the value of <see cref="MoraleRoot.m_DevineForNegative"/>
    /// </summary>
    ///
    /// <param name="devineForNegative">
    /// <para>
    /// Tooltip: Если мораль &amp;lt; 0. Шанс негативного = UnitMorale/DevineForNegative
    /// </para>
    /// </param>
    public TBuilder SetDevineForNegative(float devineForNegative)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_DevineForNegative = devineForNegative;
        });
    }

    /// <summary>
    /// Sets the value of <see cref="MoraleRoot.m_DevineForPositive"/>
    /// </summary>
    ///
    /// <param name="devineForPositive">
    /// <para>
    /// Tooltip: Если мораль &amp;gt; 0. Шанс позитивного = UnitMorale/DevineForPositive
    /// </para>
    /// </param>
    public TBuilder SetDevineForPositive(float devineForPositive)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_DevineForPositive = devineForPositive;
        });
    }

    /// <summary>
    /// Sets the value of <see cref="MoraleRoot.m_NegativeFacts"/>
    /// </summary>
    ///
    /// <param name="negativeFacts">
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
    public TBuilder SetNegativeFacts(params Blueprint<BlueprintUnitFactReference>[] negativeFacts)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_NegativeFacts = negativeFacts.Select(bp => bp.Reference).ToArray();
        });
    }

    /// <summary>
    /// Adds to the contents of <see cref="MoraleRoot.m_NegativeFacts"/>
    /// </summary>
    ///
    /// <param name="negativeFacts">
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
    public TBuilder AddToNegativeFacts(params Blueprint<BlueprintUnitFactReference>[] negativeFacts)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_NegativeFacts = bp.m_NegativeFacts ?? new BlueprintUnitFactReference[0];
          bp.m_NegativeFacts = CommonTool.Append(bp.m_NegativeFacts, negativeFacts.Select(bp => bp.Reference).ToArray());
        });
    }

    /// <summary>
    /// Removes elements from <see cref="MoraleRoot.m_NegativeFacts"/>
    /// </summary>
    ///
    /// <param name="negativeFacts">
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
    public TBuilder RemoveFromNegativeFacts(params Blueprint<BlueprintUnitFactReference>[] negativeFacts)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.m_NegativeFacts is null) { return; }
          bp.m_NegativeFacts = bp.m_NegativeFacts.Where(val => !negativeFacts.Contains(val)).ToArray();
        });
    }

    /// <summary>
    /// Removes elements from <see cref="MoraleRoot.m_NegativeFacts"/> that match the provided predicate.
    /// </summary>
    public TBuilder RemoveFromNegativeFacts(Func<BlueprintUnitFactReference, bool> predicate)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.m_NegativeFacts is null) { return; }
          bp.m_NegativeFacts = bp.m_NegativeFacts.Where(e => !predicate(e)).ToArray();
        });
    }

    /// <summary>
    /// Removes all elements from <see cref="MoraleRoot.m_NegativeFacts"/>
    /// </summary>
    public TBuilder ClearNegativeFacts()
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_NegativeFacts = new BlueprintUnitFactReference[0];
        });
    }

    /// <summary>
    /// Modifies <see cref="MoraleRoot.m_NegativeFacts"/> by invoking the provided action on each element.
    /// </summary>
    public TBuilder ModifyNegativeFacts(Action<BlueprintUnitFactReference> action)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.m_NegativeFacts is null) { return; }
          bp.m_NegativeFacts.ForEach(action);
        });
    }

    /// <summary>
    /// Sets the value of <see cref="MoraleRoot.m_GlobalArmiesMoraleBuff"/>
    /// </summary>
    ///
    /// <param name="globalArmiesMoraleBuff">
    /// <para>
    /// Blueprint of type BlueprintKingdomBuff. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder SetGlobalArmiesMoraleBuff(Blueprint<BlueprintKingdomBuffReference> globalArmiesMoraleBuff)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_GlobalArmiesMoraleBuff = globalArmiesMoraleBuff?.Reference;
        });
    }

    /// <summary>
    /// Modifies <see cref="MoraleRoot.m_GlobalArmiesMoraleBuff"/> by invoking the provided action.
    /// </summary>
    public TBuilder ModifyGlobalArmiesMoraleBuff(Action<BlueprintKingdomBuffReference> action)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.m_GlobalArmiesMoraleBuff is null) { return; }
          action.Invoke(bp.m_GlobalArmiesMoraleBuff);
        });
    }

    /// <summary>
    /// Sets the value of <see cref="MoraleRoot.BaseMoraleValue"/>
    /// </summary>
    ///
    /// <param name="baseMoraleValue">
    /// You can pass in the string using a LocalizedString or the Key to a LocalizedString.
    /// </param>
    public TBuilder SetBaseMoraleValue(LocalString baseMoraleValue)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.BaseMoraleValue = baseMoraleValue?.LocalizedString;
        });
    }

    /// <summary>
    /// Modifies <see cref="MoraleRoot.BaseMoraleValue"/> by invoking the provided action.
    /// </summary>
    public TBuilder ModifyBaseMoraleValue(Action<LocalizedString> action)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.BaseMoraleValue is null) { return; }
          action.Invoke(bp.BaseMoraleValue);
        });
    }

    /// <summary>
    /// Sets the value of <see cref="MoraleRoot.ArmyEffectOnSquad"/>
    /// </summary>
    ///
    /// <param name="armyEffectOnSquad">
    /// You can pass in the string using a LocalizedString or the Key to a LocalizedString.
    /// </param>
    public TBuilder SetArmyEffectOnSquad(LocalString armyEffectOnSquad)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.ArmyEffectOnSquad = armyEffectOnSquad?.LocalizedString;
        });
    }

    /// <summary>
    /// Modifies <see cref="MoraleRoot.ArmyEffectOnSquad"/> by invoking the provided action.
    /// </summary>
    public TBuilder ModifyArmyEffectOnSquad(Action<LocalizedString> action)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.ArmyEffectOnSquad is null) { return; }
          action.Invoke(bp.ArmyEffectOnSquad);
        });
    }

    /// <summary>
    /// Sets the value of <see cref="MoraleRoot.UnitNotHaveMorale"/>
    /// </summary>
    ///
    /// <param name="unitNotHaveMorale">
    /// You can pass in the string using a LocalizedString or the Key to a LocalizedString.
    /// </param>
    public TBuilder SetUnitNotHaveMorale(LocalString unitNotHaveMorale)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.UnitNotHaveMorale = unitNotHaveMorale?.LocalizedString;
        });
    }

    /// <summary>
    /// Modifies <see cref="MoraleRoot.UnitNotHaveMorale"/> by invoking the provided action.
    /// </summary>
    public TBuilder ModifyUnitNotHaveMorale(Action<LocalizedString> action)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.UnitNotHaveMorale is null) { return; }
          action.Invoke(bp.UnitNotHaveMorale);
        });
    }

    protected override void OnConfigureCompleted()
    {
      base.OnConfigureCompleted();
    
      if (Blueprint.m_NegativeFacts is null)
      {
        Blueprint.m_NegativeFacts = new BlueprintUnitFactReference[0];
      }
      if (Blueprint.m_GlobalArmiesMoraleBuff is null)
      {
        Blueprint.m_GlobalArmiesMoraleBuff = BlueprintTool.GetRef<BlueprintKingdomBuffReference>(null);
      }
      if (Blueprint.BaseMoraleValue is null)
      {
        Blueprint.BaseMoraleValue = Utils.Constants.Empty.String;
      }
      if (Blueprint.ArmyEffectOnSquad is null)
      {
        Blueprint.ArmyEffectOnSquad = Utils.Constants.Empty.String;
      }
      if (Blueprint.UnitNotHaveMorale is null)
      {
        Blueprint.UnitNotHaveMorale = Utils.Constants.Empty.String;
      }
    }
  }
}

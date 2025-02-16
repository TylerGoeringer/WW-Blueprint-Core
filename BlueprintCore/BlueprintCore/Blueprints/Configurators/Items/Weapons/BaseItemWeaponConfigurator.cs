//***** AUTO-GENERATED - DO NOT EDIT *****//

using BlueprintCore.Blueprints.Configurators.Items.Equipment;
using BlueprintCore.Blueprints.CustomConfigurators;
using BlueprintCore.Utils;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Items.Ecnchantments;
using Kingmaker.Blueprints.Items.Weapons;
using Kingmaker.Enums;
using Kingmaker.RuleSystem;
using Kingmaker.RuleSystem.Rules.Damage;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using Kingmaker.UnitLogic.Class.Kineticist;
using Kingmaker.Utility;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlueprintCore.Blueprints.Configurators.Items.Weapons
{
  /// <summary>
  /// Implements common fields and components for blueprints inheriting from <see cref="BlueprintItemWeapon"/>.
  /// </summary>
  /// <inheritdoc/>
  public abstract class BaseItemWeaponConfigurator<T, TBuilder>
    : BaseItemEquipmentHandConfigurator<T, TBuilder>
    where T : BlueprintItemWeapon
    where TBuilder : BaseItemWeaponConfigurator<T, TBuilder>
  {
    protected BaseItemWeaponConfigurator(Blueprint<BlueprintReference<T>> blueprint) : base(blueprint) { }

    /// <inheritdoc cref="RootConfigurator{T, TBuilder}.CopyFrom(Blueprint{BlueprintReference{BlueprintScriptableObject}}, Type[])"/>
    public TBuilder CopyFrom(
      Blueprint<BlueprintReference<BlueprintItemWeapon>> blueprint, params Type[] componentTypes)
    {
      base.CopyFrom(blueprint.ToString(), componentTypes);
    
      return OnConfigureInternal(
        bp =>
        {
          var copyFrom = blueprint.Reference.Get();
          bp.m_Type = copyFrom.m_Type;
          bp.m_Size = copyFrom.m_Size;
          bp.m_Enchantments = copyFrom.m_Enchantments;
          bp.m_OverrideDamageDice = copyFrom.m_OverrideDamageDice;
          bp.m_DamageDice = copyFrom.m_DamageDice;
          bp.m_OverrideDamageType = copyFrom.m_OverrideDamageType;
          bp.m_DamageType = copyFrom.m_DamageType;
          bp.CountAsDouble = copyFrom.CountAsDouble;
          bp.Double = copyFrom.Double;
          bp.m_SecondWeapon = copyFrom.m_SecondWeapon;
          bp.KeepInPolymorph = copyFrom.KeepInPolymorph;
          bp.m_OverrideShardItem = copyFrom.m_OverrideShardItem;
          bp.m_OverrideDestructible = copyFrom.m_OverrideDestructible;
          bp.m_AlwaysPrimary = copyFrom.m_AlwaysPrimary;
          bp.m_IsCanChangeVisualOverriden = copyFrom.m_IsCanChangeVisualOverriden;
          bp.m_CanChangeVisual = copyFrom.m_CanChangeVisual;
        });
    }

    /// <inheritdoc cref="RootConfigurator{T, TBuilder}.CopyFrom(Blueprint{BlueprintReference{BlueprintScriptableObject}}, Predicate{BlueprintComponent})"/>
    public TBuilder CopyFrom(
      Blueprint<BlueprintReference<BlueprintItemWeapon>> blueprint, Predicate<BlueprintComponent> componentMatcher)
    {
      base.CopyFrom(blueprint.ToString(), componentMatcher);
    
      return OnConfigureInternal(
        bp =>
        {
          var copyFrom = blueprint.Reference.Get();
          bp.m_Type = copyFrom.m_Type;
          bp.m_Size = copyFrom.m_Size;
          bp.m_Enchantments = copyFrom.m_Enchantments;
          bp.m_OverrideDamageDice = copyFrom.m_OverrideDamageDice;
          bp.m_DamageDice = copyFrom.m_DamageDice;
          bp.m_OverrideDamageType = copyFrom.m_OverrideDamageType;
          bp.m_DamageType = copyFrom.m_DamageType;
          bp.CountAsDouble = copyFrom.CountAsDouble;
          bp.Double = copyFrom.Double;
          bp.m_SecondWeapon = copyFrom.m_SecondWeapon;
          bp.KeepInPolymorph = copyFrom.KeepInPolymorph;
          bp.m_OverrideShardItem = copyFrom.m_OverrideShardItem;
          bp.m_OverrideDestructible = copyFrom.m_OverrideDestructible;
          bp.m_AlwaysPrimary = copyFrom.m_AlwaysPrimary;
          bp.m_IsCanChangeVisualOverriden = copyFrom.m_IsCanChangeVisualOverriden;
          bp.m_CanChangeVisual = copyFrom.m_CanChangeVisual;
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintItemWeapon.m_Type"/>
    /// </summary>
    ///
    /// <param name="type">
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
    public TBuilder SetType(Blueprint<BlueprintWeaponTypeReference> type)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_Type = type?.Reference;
        });
    }

    /// <summary>
    /// Modifies <see cref="BlueprintItemWeapon.m_Type"/> by invoking the provided action.
    /// </summary>
    public TBuilder ModifyType(Action<BlueprintWeaponTypeReference> action)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.m_Type is null) { return; }
          action.Invoke(bp.m_Type);
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintItemWeapon.m_Size"/>
    /// </summary>
    public TBuilder SetSize(Size size)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_Size = size;
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintItemWeapon.m_Enchantments"/>
    /// </summary>
    ///
    /// <param name="enchantments">
    /// <para>
    /// Blueprint of type BlueprintWeaponEnchantment. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder SetEnchantments(params Blueprint<BlueprintWeaponEnchantmentReference>[] enchantments)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_Enchantments = enchantments.Select(bp => bp.Reference).ToArray();
        });
    }

    /// <summary>
    /// Adds to the contents of <see cref="BlueprintItemWeapon.m_Enchantments"/>
    /// </summary>
    ///
    /// <param name="enchantments">
    /// <para>
    /// Blueprint of type BlueprintWeaponEnchantment. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder AddToEnchantments(params Blueprint<BlueprintWeaponEnchantmentReference>[] enchantments)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_Enchantments = bp.m_Enchantments ?? new BlueprintWeaponEnchantmentReference[0];
          bp.m_Enchantments = CommonTool.Append(bp.m_Enchantments, enchantments.Select(bp => bp.Reference).ToArray());
        });
    }

    /// <summary>
    /// Removes elements from <see cref="BlueprintItemWeapon.m_Enchantments"/>
    /// </summary>
    ///
    /// <param name="enchantments">
    /// <para>
    /// Blueprint of type BlueprintWeaponEnchantment. You can pass in the blueprint using:
    /// <list type ="bullet">
    ///   <item><term>A blueprint instance</term></item>
    ///   <item><term>A blueprint reference</term></item>
    ///   <item><term>A blueprint id as a string, Guid, or BlueprintGuid</term></item>
    ///   <item><term>A blueprint name registered with <see cref="BlueprintTool">BlueprintTool</see></term></item>
    /// </list>
    /// See <see cref="Blueprint{TRef}">Blueprint</see> for more details.
    /// </para>
    /// </param>
    public TBuilder RemoveFromEnchantments(params Blueprint<BlueprintWeaponEnchantmentReference>[] enchantments)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.m_Enchantments is null) { return; }
          bp.m_Enchantments = bp.m_Enchantments.Where(val => !enchantments.Contains(val)).ToArray();
        });
    }

    /// <summary>
    /// Removes elements from <see cref="BlueprintItemWeapon.m_Enchantments"/> that match the provided predicate.
    /// </summary>
    public TBuilder RemoveFromEnchantments(Func<BlueprintWeaponEnchantmentReference, bool> predicate)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.m_Enchantments is null) { return; }
          bp.m_Enchantments = bp.m_Enchantments.Where(e => !predicate(e)).ToArray();
        });
    }

    /// <summary>
    /// Removes all elements from <see cref="BlueprintItemWeapon.m_Enchantments"/>
    /// </summary>
    public TBuilder ClearEnchantments()
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_Enchantments = new BlueprintWeaponEnchantmentReference[0];
        });
    }

    /// <summary>
    /// Modifies <see cref="BlueprintItemWeapon.m_Enchantments"/> by invoking the provided action on each element.
    /// </summary>
    public TBuilder ModifyEnchantments(Action<BlueprintWeaponEnchantmentReference> action)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.m_Enchantments is null) { return; }
          bp.m_Enchantments.ForEach(action);
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintItemWeapon.m_OverrideDamageDice"/>
    /// </summary>
    public TBuilder SetOverrideDamageDice(bool overrideDamageDice = true)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_OverrideDamageDice = overrideDamageDice;
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintItemWeapon.m_DamageDice"/>
    /// </summary>
    public TBuilder SetDamageDice(DiceFormula damageDice)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_DamageDice = damageDice;
        });
    }

    /// <summary>
    /// Modifies <see cref="BlueprintItemWeapon.m_DamageDice"/> by invoking the provided action.
    /// </summary>
    public TBuilder ModifyDamageDice(Action<DiceFormula> action)
    {
      return OnConfigureInternal(
        bp =>
        {
          action.Invoke(bp.m_DamageDice);
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintItemWeapon.m_OverrideDamageType"/>
    /// </summary>
    public TBuilder SetOverrideDamageType(bool overrideDamageType = true)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_OverrideDamageType = overrideDamageType;
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintItemWeapon.m_DamageType"/>
    /// </summary>
    public TBuilder SetDamageType(DamageTypeDescription damageType)
    {
      return OnConfigureInternal(
        bp =>
        {
          Validate(damageType);
          bp.m_DamageType = damageType;
        });
    }

    /// <summary>
    /// Modifies <see cref="BlueprintItemWeapon.m_DamageType"/> by invoking the provided action.
    /// </summary>
    public TBuilder ModifyDamageType(Action<DamageTypeDescription> action)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.m_DamageType is null) { return; }
          action.Invoke(bp.m_DamageType);
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintItemWeapon.CountAsDouble"/>
    /// </summary>
    ///
    /// <param name="countAsDouble">
    /// <para>
    /// InfoBox: Считать за два оружия, для PF-497061
    /// </para>
    /// </param>
    public TBuilder SetCountAsDouble(bool countAsDouble = true)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.CountAsDouble = countAsDouble;
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintItemWeapon.Double"/>
    /// </summary>
    public TBuilder SetDoubleValue(bool doubleValue = true)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.Double = doubleValue;
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintItemWeapon.m_SecondWeapon"/>
    /// </summary>
    ///
    /// <param name="secondWeapon">
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
    public TBuilder SetSecondWeapon(Blueprint<BlueprintItemWeaponReference> secondWeapon)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_SecondWeapon = secondWeapon?.Reference;
        });
    }

    /// <summary>
    /// Modifies <see cref="BlueprintItemWeapon.m_SecondWeapon"/> by invoking the provided action.
    /// </summary>
    public TBuilder ModifySecondWeapon(Action<BlueprintItemWeaponReference> action)
    {
      return OnConfigureInternal(
        bp =>
        {
          if (bp.m_SecondWeapon is null) { return; }
          action.Invoke(bp.m_SecondWeapon);
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintItemWeapon.KeepInPolymorph"/>
    /// </summary>
    public TBuilder SetKeepInPolymorph(bool keepInPolymorph = true)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.KeepInPolymorph = keepInPolymorph;
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintItemWeapon.m_OverrideShardItem"/>
    /// </summary>
    ///
    /// <param name="overrideShardItem">
    /// <para>
    /// InfoBox: If true, ignores shard item from weapon type and uses shard from this blueprint.
    /// </para>
    /// </param>
    public TBuilder SetOverrideShardItem(bool overrideShardItem = true)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_OverrideShardItem = overrideShardItem;
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintItemWeapon.m_OverrideDestructible"/>
    /// </summary>
    ///
    /// <param name="overrideDestructible">
    /// <para>
    /// InfoBox: If true, ignores destructible property value from armor type and uses it from blueprint item.
    /// </para>
    /// </param>
    public TBuilder SetOverrideDestructible(bool overrideDestructible = true)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_OverrideDestructible = overrideDestructible;
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintItemWeapon.m_AlwaysPrimary"/>
    /// </summary>
    public TBuilder SetAlwaysPrimary(bool alwaysPrimary = true)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_AlwaysPrimary = alwaysPrimary;
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintItemWeapon.m_IsCanChangeVisualOverriden"/>
    /// </summary>
    public TBuilder SetIsCanChangeVisualOverriden(bool isCanChangeVisualOverriden = true)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_IsCanChangeVisualOverriden = isCanChangeVisualOverriden;
        });
    }

    /// <summary>
    /// Sets the value of <see cref="BlueprintItemWeapon.m_CanChangeVisual"/>
    /// </summary>
    public TBuilder SetCanChangeVisual(bool canChangeVisual = true)
    {
      return OnConfigureInternal(
        bp =>
        {
          bp.m_CanChangeVisual = canChangeVisual;
        });
    }

    /// <summary>
    /// Adds <see cref="WeaponKineticBlade"/>
    /// </summary>
    ///
    /// <remarks>
    ///
    /// <list type="bullet">
    /// <listheader>Used by</listheader>
    /// <item><term>AirKineticBladeWeapon</term><description>43ff67143efb86d4f894b10577329050</description></item>
    /// <item><term>IceKineticBladeWeapon</term><description>a1eee0a2735401546ba2b442e1a9d25d</description></item>
    /// <item><term>WaterKineticBladeWeapon</term><description>6a1bc011f6bbc7745876ce2692ecdfb5</description></item>
    /// </list>
    /// </remarks>
    ///
    /// <param name="activationAbility">
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
    /// <param name="blast">
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
    /// <param name="merge">
    /// If mergeBehavior is ComponentMerge.Merge and the component already exists, this expression is called to merge the components.
    /// </param>
    /// <param name="mergeBehavior">
    /// Handling if the component already exists since the component is unique. Defaults to ComponentMerge.Fail.
    /// </param>
    public TBuilder AddWeaponKineticBlade(
        Blueprint<BlueprintAbilityReference>? activationAbility = null,
        Blueprint<BlueprintAbilityReference>? blast = null,
        Action<BlueprintComponent, BlueprintComponent>? merge = null,
        ComponentMerge mergeBehavior = ComponentMerge.Fail)
    {
      var component = new WeaponKineticBlade();
      component.m_ActivationAbility = activationAbility?.Reference ?? component.m_ActivationAbility;
      if (component.m_ActivationAbility is null)
      {
        component.m_ActivationAbility = BlueprintTool.GetRef<BlueprintAbilityReference>(null);
      }
      component.m_Blast = blast?.Reference ?? component.m_Blast;
      if (component.m_Blast is null)
      {
        component.m_Blast = BlueprintTool.GetRef<BlueprintAbilityReference>(null);
      }
      return AddUniqueComponent(component, mergeBehavior, merge);
    }

    protected override void OnConfigureCompleted()
    {
      base.OnConfigureCompleted();
    
      if (Blueprint.m_Type is null)
      {
        Blueprint.m_Type = BlueprintTool.GetRef<BlueprintWeaponTypeReference>(null);
      }
      if (Blueprint.m_Enchantments is null)
      {
        Blueprint.m_Enchantments = new BlueprintWeaponEnchantmentReference[0];
      }
      if (Blueprint.m_SecondWeapon is null)
      {
        Blueprint.m_SecondWeapon = BlueprintTool.GetRef<BlueprintItemWeaponReference>(null);
      }
    }
  }
}

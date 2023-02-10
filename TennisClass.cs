using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace WorhyMod
{
	public class TennisClass : DamageClass
	{
		public override void SetStaticDefaults()
		{
			ClassName.SetDefault("Tennis Class");
		}
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass)
		{
			if (damageClass == DamageClass.Generic)
				return StatInheritanceData.Full;

			return new StatInheritanceData(
				damageInheritance: 0f,
				critChanceInheritance: 0f,
				attackSpeedInheritance: 0f,
				armorPenInheritance: 0f,
				knockbackInheritance: 0f
			);
		}

		public override bool GetEffectInheritance(DamageClass damageClass)
		{
			if (damageClass == DamageClass.Melee)
				return true;
			if (damageClass == DamageClass.Magic)
				return true;

			return false;
		}

		public override void SetDefaultStats(Player player)
		{
			player.GetCritChance<TennisClass>() += 4;
			player.GetArmorPenetration<TennisClass>() += 10;
		}
		public override bool UseStandardCritCalcs => true;

		public override bool ShowStatTooltipLine(Player player, string lineName)
		{
			if (lineName == "Speed")
				return false;

			return true;
		}
	}
}
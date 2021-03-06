﻿#region Copyright & License Information
/*
 * Copyright 2007-2014 The OpenRA Developers (see AUTHORS)
 * This file is part of OpenRA, which is free software. It is made
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation. For more information,
 * see COPYING.
 */
#endregion

using OpenRA.Traits;

namespace OpenRA.Mods.RA
{
	[Desc("Tag trait for construction yard and MCVs. Used by the cycle bases hotkey to identify actors.")]
	public class BaseBuildingInfo : TraitInfo<BaseBuilding> { }
	public class BaseBuilding { }
}

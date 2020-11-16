﻿using System.Collections.Generic;
using L2ScriptMaker.Core.WinForms;
using L2ScriptMaker.Models.Npc;

namespace L2ScriptMaker.Services.Npc
{
	public interface INpcPchService : IDataService<NpcPch>, IProgressService, IGenerateService
	{
		List<ListItem> GetListItems(string fileName);
	}
}
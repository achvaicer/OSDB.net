﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDBnet {
	public interface IAnonymousClient : IDisposable {
		IEnumerable<Subtitle> SearchSubtitles(string filename);
		string DownloadSubtitleToPath(string path, Subtitle subtitle);
	}
}
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System;

namespace CustomNameList
{
    class CustomNameService {
        private static Random rng = new Random();
        private readonly string _textFile;
        private List<String> _allNames;
        private Stack<String> _nextNames;

        internal bool IsInitialized { get; private set; }

        public CustomNameService(string textFile) {
            _textFile = textFile;
        }

        internal void Init() {
            if (!File.Exists(_textFile)) {
                Plugin.Log.LogError($"Could not find names file at: {_textFile}");
                Plugin.Log.LogWarning($"Will use standard game names instead.");
                return;
            }

            _allNames = File.ReadAllLines(_textFile).ToList().Select(e => e.Trim().Replace("\r", "")).ToList();

            Plugin.Log.LogInfo($"Read {_allNames.Count()} names from {_textFile}");

            RefillNames();

            IsInitialized = true;
        }

        internal String NextName() {
            if(_nextNames.Count == 0)
                RefillNames();

            var nextName = _nextNames.Pop();

            return nextName;
        }

        private void RefillNames() {
            _nextNames = new Stack<String>(_allNames.OrderBy(a => rng.Next()));
        }
    }
}
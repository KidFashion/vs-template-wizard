#region LICENSE
/*
 *   Copyright 2014 Angelo Simone Scotto <scotto.a@gmail.com>
 * 
 *   Licensed under the Apache License, Version 2.0 (the "License");
 *   you may not use this file except in compliance with the License.
 *   You may obtain a copy of the License at
 * 
 *       http://www.apache.org/licenses/LICENSE-2.0
 * 
 *   Unless required by applicable law or agreed to in writing, software
 *   distributed under the License is distributed on an "AS IS" BASIS,
 *   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *   See the License for the specific language governing permissions and
 *   limitations under the License.
 * 
 * */
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPSoftware.VisualStudio.GenericTemplateWizard
{
    public static class GlobalDictionary
    {
        private static Dictionary<String, String> _innerDictionary = new Dictionary<string, string>();

        public static void CopyGlobalDictionaryToReplacementsDictionary(ref Dictionary<string, string> replacementsDictionary)
        {
            foreach (var pair in _innerDictionary)
            {
                if (replacementsDictionary.ContainsKey(pair.Key)) replacementsDictionary[pair.Key] = pair.Value;
                else replacementsDictionary.Add(pair.Key,pair.Value);
            }            
        }

        public static void CopyReplacementsDictionaryToGlobalDictionary(ref Dictionary<string, string> replacementsDictionary)
        {
            foreach (var pair in replacementsDictionary)
            {
                if (_innerDictionary.ContainsKey(pair.Key)) _innerDictionary[pair.Key] = pair.Value;
                else _innerDictionary.Add(pair.Key, pair.Value);
            }
        }

        public static void Set(String key, String value)
        {
            if (_innerDictionary.ContainsKey(key)) _innerDictionary[key] = value;
            else _innerDictionary.Add(key, value);
        }

        public static String Get(String key)
        {
            if (_innerDictionary.ContainsKey(key)) return _innerDictionary[key];
            else return String.Empty;
        }

        public static void Reset()
        {
            _innerDictionary.Clear();
        }
    }
}

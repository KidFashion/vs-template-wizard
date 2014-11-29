using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTemplateWizard
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

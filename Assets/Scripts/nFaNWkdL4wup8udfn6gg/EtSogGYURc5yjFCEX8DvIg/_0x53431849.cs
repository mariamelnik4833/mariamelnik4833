using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0x53431849
{
    public static class _0x0733d9ad
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public class _0xe77d69ac
    {
        private static readonly _0xe77d69ac _0x10c95241 = new();
        public static readonly _0xe77d69ac[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0x10c95241,
            _0x10c95241,
            _0x10c95241,
        };
        private int _0xa3946160 => 0;
        private int _0x140189e5 => 10;
        private string _0x30215397 => _0xa22e4931._0xc618eb96(new byte[4] { 84, 124, 119, 108 }, 25);
        private string _0x6853f2ac => _0xa22e4931._0xc618eb96(new byte[8] { 163, 170, 185, 170, 163, 148, 223, 146 }, 239);

        private int _0xc3468806
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0xa22e4931._0xc618eb96(new byte[25] { 251, 205, 202, 202, 221, 214, 204, 255, 212, 215, 218, 217, 212, 251, 208, 217, 200, 204, 221, 202, 241, 214, 220, 221, 192 }, 184)))
                    PlayerPrefs.SetInt(_0xa22e4931._0xc618eb96(new byte[25] { 140, 186, 189, 189, 170, 161, 187, 136, 163, 160, 173, 174, 163, 140, 167, 174, 191, 187, 170, 189, 134, 161, 171, 170, 183 }, 207), 0);
                return PlayerPrefs.GetInt(_0xa22e4931._0xc618eb96(new byte[25] { 201, 255, 248, 248, 239, 228, 254, 205, 230, 229, 232, 235, 230, 201, 226, 235, 250, 254, 239, 248, 195, 228, 238, 239, 242 }, 138));
            }

            set => PlayerPrefs.SetInt(_0xa22e4931._0xc618eb96(new byte[25] { 241, 199, 192, 192, 215, 220, 198, 245, 222, 221, 208, 211, 222, 241, 218, 211, 194, 198, 215, 192, 251, 220, 214, 215, 202 }, 178), value);
        }

        public int _0xf4b85fde
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x30215397}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0x30215397}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0x30215397}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0x30215397}CurrentLevelIndex", value);
        }

        public int _0x5a4063e1
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x30215397}BestScore"))
                    this._0x5a4063e1 = 0;
                return PlayerPrefs.GetInt($"{this._0x30215397}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0x30215397}BestScore", value);
        }

        public bool _0x3b876ea8
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x30215397}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0x30215397}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0x30215397}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0x30215397}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0x7146dbc1
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public static class _0xfa200dc8
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public static class _0xc5e03009
    {
        public static int _0xc95d7db8
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0xa22e4931._0xc618eb96(new byte[5] { 210, 254, 248, 255, 226 }, 145)))
                    PlayerPrefs.SetInt(_0xa22e4931._0xc618eb96(new byte[5] { 58, 22, 16, 23, 10 }, 121), 0);
                return PlayerPrefs.GetInt(_0xa22e4931._0xc618eb96(new byte[5] { 173, 129, 135, 128, 157 }, 238));
            }

            set
            {
                PlayerPrefs.SetInt(_0xa22e4931._0xc618eb96(new byte[5] { 241, 221, 219, 220, 193 }, 178), value);
                _0x86c44cb0.Instance._0x127cf751();
            }
        }
    }
}

internal static class _0xa22e4931
{
    internal static string _0xc618eb96(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}
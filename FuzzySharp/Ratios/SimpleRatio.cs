﻿using System;
using FuzzySharp.InternalDiffUtils;

namespace FuzzySharp.Ratios
{
    public class SimpleRatio : IRatio
    {
        public int Score(string s1, string s2)
        {
            return Convert.ToInt32(DiffUtils.GetRatio(s1, s2) * 100);
        }
    }
}
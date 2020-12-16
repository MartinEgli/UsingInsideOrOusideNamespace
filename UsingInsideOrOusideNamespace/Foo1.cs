// -----------------------------------------------------------------------
// <copyright file="Foo1.cs" company="Anori Soft">
// Copyright (c) Anori Soft. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

// https://stackoverflow.com/questions/125319/should-using-directives-be-inside-or-outside-the-namespace

using System;

namespace Outer.Inner
{
    public class Foo1
    {
        public static void Bar1()
        {
            var d = Math.PI;
        }
    }
}
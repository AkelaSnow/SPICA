﻿using OpenTK.Graphics.ES30;

using SPICA.PICA.Commands;

using System;

namespace SPICA.Renderer.SPICA_GL
{
    static class PICAStencilOpExtensions
    {
        public static StencilOp ToStencilOp(this PICAStencilOp Op)
        {
            switch (Op)
            {
                case PICAStencilOp.Keep:          return StencilOp.Keep;
                case PICAStencilOp.Zero:          return StencilOp.Zero;
                case PICAStencilOp.Replace:       return StencilOp.Replace;
                case PICAStencilOp.Increment:     return StencilOp.Incr;
                case PICAStencilOp.Decrement:     return StencilOp.Decr;
                case PICAStencilOp.Invert:        return StencilOp.Invert;
                case PICAStencilOp.IncrementWrap: return StencilOp.IncrWrap;
                case PICAStencilOp.DecrementWrap: return StencilOp.DecrWrap;

                default: throw new ArgumentException("Invalid Stencil operation!");
            }
        }
    }
}
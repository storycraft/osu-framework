// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using osu.Framework.Graphics.Primitives;
using osu.Framework.Graphics.Textures;

namespace osu.Framework.Graphics.Sprites
{
    /// <summary>
    /// A character of a <see cref="SpriteText"/> provided with local space coordinates.
    /// </summary>
    internal struct CharacterPart
    {
        /// <summary>
        /// The local-space rectangle for the character to be drawn in.
        /// </summary>
        public RectangleF DrawRectangle;

        /// <summary>
        /// The texture to draw the character with.
        /// </summary>
        public Texture Texture;
    }
}

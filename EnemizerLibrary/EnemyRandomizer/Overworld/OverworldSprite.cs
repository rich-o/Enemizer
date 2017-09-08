﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemizerLibrary
{
    public class OverworldSprite
    {
        public int SpriteAddress { get; set; }
        public byte SpriteId { get; set; }
        public byte SpriteX { get; set; }
        public byte SpriteY { get; set; }
        public string SpriteName
        {
            get
            {
                return SpriteConstants.GetSpriteName(SpriteId);
            }
        }

        RomData romData;
        public OverworldSprite(RomData romData, int SpriteAddress)
        {
            this.romData = romData;
            this.SpriteAddress = SpriteAddress;
            this.SpriteY = romData[SpriteAddress];
            this.SpriteX = romData[SpriteAddress + 1];
            this.SpriteId = romData[SpriteAddress + 2];
        }

        public void UpdateRom()
        {
            // TODO: should we allow moving sprites? Would be useful for Pedestal and Zora's Domain

            //romData[SpriteAddress] = SpriteY;
            //romData[SpriteAddress] = SpriteX;
            romData[SpriteAddress + 2] = SpriteId;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace SamFirm
{
    class FirmwareInfo
    {
        private int id;
        private string model;
        private string region;

        public int Id { get => id; set => id = value; }
        public string Model { get => model; set => model = value; }
        public string Region { get => region; set => region = value; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCManager.Backups
{
    public interface IBackup
    {
        void Extract();

        string GetName();

        string GetDescription();

        string GetBackupType();

        IBackupFormat GetFormat();

        string GetFilePath();
    }
}
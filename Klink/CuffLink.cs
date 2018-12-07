﻿/* ----------------------------------------------------------------------------
Cufflink - an COFF object file linker
Copyright (C) 1997-2018  George E Greaney

This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
----------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CuffLink
{
    class CuffLink
    {
        Options options;

        static void Main(string[] args)
        {
            Options options = new Options(args);        //parse the cmd line args

            CuffLink linker = new CuffLink(options);        //create a linker
            linker.link();

        }

        public CuffLink(Options _options)
        {
           options = _options;
        }

        public void link()
        {
            throw new NotImplementedException();
        }

    }
}
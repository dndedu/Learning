﻿using System;

string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin") && level > 55)
    Console.WriteLine("Welcome, Super Admin user.");
elseif()
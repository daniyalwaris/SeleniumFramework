﻿
namespace SeleniumFramework.UIElements
{
    public class Menu
    {
    }
}

version: 2.1

 orbs:
  win: circleci/windows@2.2.0

 jobs:
   build:
     executor: win/default     
    
     steps:
       - checkout
       - run: dotnet build

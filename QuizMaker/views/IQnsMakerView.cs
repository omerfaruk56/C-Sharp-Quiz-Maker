﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizMaker.models;
namespace QuizMaker.Views
{
    public interface IQnsMakerView
    {
       
        void saveQnsMakerGrid(IList<QuestionMaker> liste);
    }
}

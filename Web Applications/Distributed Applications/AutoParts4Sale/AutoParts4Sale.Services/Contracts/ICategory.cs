﻿using AutoParts4Sale.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoParts4Sale.Services.Contracts
{
    interface ICategory
    {
        IEnumerable<Category> GetCategoriesByName(string name);
        Category GetById(int id);
        Category Update(Category updatedCategory);
        Category Add(Category category);
        Category Delete(int id);
        int Commit();
    }
}

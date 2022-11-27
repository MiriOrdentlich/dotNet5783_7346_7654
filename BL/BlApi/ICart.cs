﻿using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi;

public interface ICart
{
    void AddItem(Cart cart, int productId);
    void UpdateItemAmount(Cart cart, int productId, int amount);
    void ConfirmCart(Cart cart, string name, string email, string adress);

}

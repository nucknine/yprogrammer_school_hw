using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InternetStore.Models
{
    /*
    public class ShoppingCart
    {
        StoreEntities storeDb = new StoreEntities();
        string ShoppingCartId { get; set; }

        public const string CartSessionKey = "CartId";

        public static ShoppingCart GetCart(HttpContextBase context)
        {
            var cart = new ShoppingCart();
            //cart.ShoppingCartId = cart.GetCartId(context);
            return cart;
        }

        public static ShoppingCart GetCart(Controller controller)
        {
            return GetCart(controller.HttpContext);
        }

        public void AddToCart(Item Item)
        {
            var cartItem = storeDb.Carts.SingleOrDefault(
                c => c.CartId == ShoppingCartId
                && c.ItemId == Item.ItemId
                );

            if (cartItem == null)
            {
                cartItem = new Cart
                {
                    ItemId = Item.ItemId,
                    CartId = ShoppingCartId,
                    Count = 1,
                    DateCreated = DateTime.Now
                };

                storeDb.Carts.Add(cartItem);
            } else
            {
                cartItem.Count++;
            }

            storeDb.SaveChanges();
        }

        public int RemoveFromCart(int id)
        {
            var cartItem = storeDb.Carts.Single(
                cart => cart.CartId == ShoppingCartId
                && cart.RecordId == id);

            int itemCount = 0;

            if (cartItem != null)
            {
                if(cartItem.Count > 1)
                {
                    cartItem.Count--;
                    itemCount = cartItem.Count;
                } else
                {
                    storeDb.Carts.Remove(cartItem);
                }
                storeDb.SaveChanges();
            }

            return itemCount;
        }

        public void EmptyCart()
        {
            var cartItems = storeDb.Carts.Where(
                cart => cart.CartId == ShoppingCartId);

            foreach (var cartItem in cartItems)
            {
                storeDb.Carts.Remove(cartItem);
            }

            storeDb.SaveChanges();
        }

        public List<Cart> GetCartItems()
        {
            return storeDb.Carts.Where(
                cart => cart.CartId == ShoppingCartId).ToList();
        }

        public int GetCount()
        {
            int? count = (from cartItems in storeDb.Carts
                          where cartItems.CartId == ShoppingCartId
                          select (int?)cartItems.Count).Sum();

            return count ?? 0;
        }
    }
    */
}
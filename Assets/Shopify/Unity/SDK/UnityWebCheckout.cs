#if UNITY_EDITOR || UNITY_STANDALONE
namespace Shopify.Unity.SDK {
    using System;
    using Shopify.Unity.SDK;
    using UnityEngine;

    class UnityWebCheckout : WebCheckout {
        private ShopifyClient _client;
        private Cart _cart;

        protected override ShopifyClient Client {
            get {
                return _client;
            }
        }

        protected override Cart Cart {
            get {
                return _cart;
            }
        }

        public UnityWebCheckout(Cart cart, ShopifyClient client) {
            _cart = cart;
            _client = client;
        }

        public override void Checkout(string checkoutURL, CheckoutSuccessCallback success, CheckoutCancelCallback cancelled, CheckoutFailureCallback failure) {
            SetupWebCheckoutMessageReceiver(success, cancelled, failure);
            Application.OpenURL(checkoutURL);
        }
    }
}
#endif

namespace Shopify.Unity.SDK {
    using System;

    abstract class WebCheckout {
        private static WebCheckoutMessageReceiver _messageReceiver;

        protected abstract ShopifyClient Client { get; }
        protected abstract Cart Cart { get; }

        public abstract void Checkout(string checkoutURL, CheckoutSuccessCallback success, CheckoutCancelCallback cancelled, CheckoutFailureCallback failure);

        protected void SetupWebCheckoutMessageReceiver(CheckoutSuccessCallback success, CheckoutCancelCallback cancelled, CheckoutFailureCallback failure) {
            if (_messageReceiver == null) {
                _messageReceiver = GlobalGameObject.AddComponent<WebCheckoutMessageReceiver>();
            }

            _messageReceiver.Init(Client, Cart.CurrentCheckout, success, cancelled, failure);
        }

        protected String GetNativeMessageReceiverName() {
            return GlobalGameObject.Name;
        }
    }
}

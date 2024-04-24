using Stripe;
using Stripe.Checkout;
using EasyBizPos.Models;
using System.Collections.Generic;
using System;

public class StripePaymentProcessor
{
    public StripePaymentProcessor()
    {
        // Stripe Test Card Information for Demo Purposes
        // Use these details for testing Stripe payment integration in test mode.

        // Test card number for a successful payment:
        // - Card Number: '4242 4242 4242 4242' (Visa)

        // Test card expiration date (any future date):
        // - Expiration Month: '12' (December)
        // - Expiration Year: '34' (Year 2034)

        // Test card CVC (any 3 digits):
        // - CVC: '123'

        // Test card ZIP/postal code (any 5 digits):
        // - ZIP Code: '90210'

        // Test cardholder name:
        // - Name: 'Test User'

        // Test email (Stripe does not send emails in test mode):
        // - Email: 'test@example.com'

        // Fake phone number (Stripe does not validate phone numbers in test mode):
        // - Phone Number: '(555) 555-5555'
        // Set your secret key. Remember to switch to your live secret key in production!
        // See your keys here: https://dashboard.stripe.com/apikeys
        StripeConfiguration.ApiKey = "sk_test_51P8a0FP52rhBuEmxhnNVealsHcOoQxbYIQ6qXIRmdOwSPVQkzGlKAweiKBbpUrNVl78tU2agivfVAlpjF5YvlPYG00MDC9UvIo";
    }

    public string CreateCheckoutSession()
    {
        // Get the cart instance
        Cart cart = Cart.Instance;

        if (cart.getCart().Count == 0)
        {
            throw new InvalidOperationException("Cannot create a checkout session for an empty cart.");
        }

        var lineItems = new List<SessionLineItemOptions>();

        // Adding each cart item as a line item in the Stripe session
        foreach (var cartItem in cart.getCart())
        {
            lineItems.Add(new SessionLineItemOptions
            {
                PriceData = new SessionLineItemPriceDataOptions
                {
                    UnitAmount = Convert.ToInt64(cartItem.Price * 100), // Convert price to cents
                    Currency = "usd",
                    ProductData = new SessionLineItemPriceDataProductDataOptions
                    {
                        Name = cartItem.Name,
                        // Omitting the description as per your previous instruction
                    },
                },
                Quantity = cartItem.Quantity,
            });
        }

        var options = new SessionCreateOptions
        {
            PaymentMethodTypes = new List<string> { "card" },
            LineItems = lineItems,
            Mode = "payment",
            SuccessUrl = "https://example.com/success",
            CancelUrl = "https://example.com/cancel",
        };

        var service = new SessionService();
        Session session = service.Create(options);

        return session.Url; // Return the URL to the frontend to redirect the user to Stripe's Checkout page
    }
}

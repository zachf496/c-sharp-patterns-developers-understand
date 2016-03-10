#Factory

The factory pattern is designed to abstract away object creation to another object.

##Example Usages

Let's say Acme Corp has shipped a cool new SDK. Inside the SDK is a model called `Foo`. You decided to build an app against this SDK and create a bunch of `Foo` objects with `new Foo()`. Everything works great but then a feature update arrives from Acme and it contains a breaking change because you now need to use `Foo` with a parameter.

You then update your code to use the new signature and everything works again or at least until the next change. This is not ideal for anyone. Wouldn't it be great to not have to change your app when Acme decides to change how `Foo` needs to be used?

The factory pattern allows for the user to delegate the creation of an object and allows the factory creator to tinker and change the implementation details so long as it returns an interface or abstract class.

##Pros

Read the scenario above :)

##Cons

Requires the use of interface/abstract class and a factory method which will be a bit more involved.

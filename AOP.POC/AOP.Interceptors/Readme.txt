AOP Using Interceptors:
We can attach aspects to our business functionality at run time 
or 
complile time based upon the way and aspect framework is choosen and configured.

Addition of Aspects to the business functionality using INterceptors require IOC containers. 
IOC Containers like 
Unity,
Ninject & 
Castle Windsor has option to attach interceptors to the your class. The aspects are added to a method/class using dynamic proxies.

Conceptually, this is what happens 

Calling Code
	|
	(Give me concreate implementation of type IInterface.)
	|
IOC Container
	|
	(Based on IOC Configuration gets a concreate implementation of IInterface).
	|
	(Checks if any Interceptors are tagged for this call)
	|
	(If Yes then pass the concreate Class to Dynamic Proxy)
	|
Dynamic Proxy
	|
	(Added Interceptors around the Concrete Class and return a new ProxyClass of Type IInterface to calling Code.
	|
Calling code

		

**NDDDSample** is the project which demonstrates a practical implementation of the building block patterns described in the Eric Evans book based on a real but simplified cargo domain (which is also used as example in [Eric Evans](http://domaindrivendesign.org/about/index.html#eric) [book](http://www.amazon.com/Domain-Driven-Design-Tackling-Complexity-Software/dp/0321125215)).

**NDDDSample** is the port of Domain-Driven Design Sample from Java to C#

**NDDDSample** consists of the following parts:
- Web interface allowing to book and track cargos.
- RegisterApp allowing to register handling events for cargos.

#Solutions

There are two solutions:
1. Web Cargo Tracking Application - _NDDDSample.sln_
2. Register desktop Application - _RegisterApp.sln_ which simulates concept where are two different organizations, as it is in the Java version of the DDD sample
3. _NDDDSample-full.sln_ doesn't have any business\domain meaning it is just full solution with all developed projects
4. _NDDDSample-full-with-setup.sln_ similar as from p.3 but with a setup project
5. _NDDDSample-Cloud-full.sln_ is cloud (Windws Azure) version of application

#Building

**ASP.NET MVC 2.0** must be installed. In order to build the source, run the _build.bat_ file. (You'll find the built assemblies in subfolders of _/build_ directory.)

**Note:** The cloud version can be built and run only from Visual Studio 2010.

**Windows Azure SDK** needs to be installed. You can find it under _tools\WindowsAzureSDK_

#Running

In order to run application first build the source. See the building section.

- NDDDSample
	1.	To run setup from p.2 Visual Studio should be installed. Please verify also if property "vs" in "NDDDSample.build" file corresponds to the path of installed Visual Studio.
	2.	Setup NDDDSample by running _setup_NDDDSample.bat_ This will install Cassini Web Server and NDDDSample application.
	3.	Execute _run_NDDDSample.bat_ to run NDDDSample. the following services are run automatically:
		- _NDDDSample.Interfaces.BookingRemoteService.Host.exe_
		- WCF service allowing to book cargos
		- _NDDDSample.Interfaces.PathfinderRemoteService.Host.exe_
		- WCF service allowing to find itineraries the default browser is started with home page of NDDDSample web interface
-	NDDDSample in the Cloud
	1.	Set up _NDDDCloudService_ project as the start-up project
	2.	Press (Ctrl + F5)/F5 to run/debug the solution
-	RegisterApp
	1.	Execute _run_RegisterApp.bat_ to run RegisterApp. The following services are run automatically:
		- _build\NDDDSample.Interfaces.HandlingService.Host\NDDDSample.Interfaces.HandlingService.Host.exe_ the application RegisterApp is started

#More Details

The last version of the project and details can be found on project's home page: ~~http://code.google.com/p/ndddsample/~~.

**Note:** The SVN repository on Google Code will be discontinued shortly due to the termination of the Google Code project.
The current repository represents the final state in which the original repository has been left in.

#License

- The **NDDDSample** is the property of Artur Trosin and the project's contributors.
- The project is lincensed under the [MIT Licence](http://opensource.org/licenses/MIT).

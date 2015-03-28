<a href='http://en.wikipedia.org/wiki/Domain-driven_design'>Domain-Driven Design</a>(DDD)  is a complex and broad topic which is full of patterns and practices that are very well described in <a href='http://domaindrivendesign.org/about/index.html#eric'>Eric Evan’s</a> <a href='http://www.amazon.com/Domain-Driven-Design-Tackling-Complexity-Software/dp/0321125215'> book</a>. However even if you read it and understand all described there very well(i'd say which is not an easy task), the book could leave a lot of unanswered questions from practical perspective (e.g. how those things work in practice). This is because <a href='http://www.amazon.com/Domain-Driven-Design-Tackling-Complexity-Software/dp/0321125215'>the book</a> is technology - agnostic. That can’t happen for advanced developers with strong background. For most of us reading theory without seeing a practical part of the things is very boring and even could lead to unacceptable confusions.

Good DDD samples are very hard to find, that is not because they don’t exist but because real DDD power is discovered in complex domains. Mostly all DDD projects with complex domains are commercial projects. So one of the targets of the project is to demonstrate a practical implementation of the <a href='http://domaindrivendesign.org/books/evans_pt02.pdf'> building block patterns</a> described in the <a href='http://www.amazon.com/Domain-Driven-Design-Tackling-Complexity-Software/dp/0321125215'> Eric Evans book</a> based on a real but simplified cargo domain (which is also used as example in Eric Evans’ book).

The project is based on a joint effort by Eric Evans' company <a href='http://www.domainlanguage.com/index.html'> Domain Language </a>and the Swedish software consulting company <a href='http://www.citerus.se/'> Citerus</a>.

**The purpose of the project is:**
<br />    -To show practical side of DDD using <a href='http://en.wikipedia.org/wiki/.NET_Framework'>.net framework</a>
<br />    - To port <a href='http://dddsample.sourceforge.net/'>Domain-Driven Design Sample</a> from Java to C#
<br />    - Incrementally adjust the code and apply .net conventions and practices
<br />    - Use latest .net tools, technologies and software development methodologies that are widely used and discussed within <a href='http://altdotnet.org/'>alt.net group</a>
<br />    - To provide an "how-to" example for implementing a typical DDD application
<br />    - To show a decent way to do it(but not **the** way to do it). Eventually, the same design could be re-implemented on various popular platforms, to give the same assistance to people working on those platforms,and also help those who must transition between the platforms.
<br />    - To support discussion of implementation practices. Variations could show trade-offs of alternative approaches, helping the community to clarify and refine best practices for building DDD applications.

As intended side-effect of the project which is especially important for .net community is to show alternative way of application architecture through practical application sample. Sadly but true is that <a href='http://weblogs.asp.net/rosherove/archive/2007/06/04/alt-net-alternative-tools-and-approaches-to-mainstream-net.aspx'> mainstream </a> within .net community still believes in <a href='http://www.designpatternsfor.net/default.aspx?pid=30'>DataSets</a> and N-Layer\Tier architectures with <a href='http://martinfowler.com/bliki/AnemicDomainModel.html'>Anemic Domain Model</a>, <a href='http://www.agilemodeling.com/essays/bmuf.htm'>Big Design Up Front</a>, etc… and is unaware or\and doesn’t believe in <a href='http://en.wikipedia.org/wiki/Test-driven_development'>TDD</a>, <a href='http://martinfowler.com/articles/designDead.html'>Evolutionary Design and Development</a>, and other <a href='http://en.wikipedia.org/wiki/Agile_software_development'>Agile</a> practices. So, in the project we will try to cover <a href='http://altnetpedia.com/Practices.ashx'>alt.net practices</a> as much as possible.

<b>We are open to discuss any aspects that could increase quality of the sample for sake of sharing with community.</b>

For those who are new in DDD <a href='http://weblogs.asp.net/arturtrosin/archive/2009/02/09/domain-driven-design-learning.aspx'>here is my post</a> that could help to enter into the topic.
<br />

---

**!!!UPDATE - Dec 10, 2010!!!**
Yes, there are new **Updates**... I want to declare that NDDD Sample application(s) is **released**. In the release are fixed all known bugs and issues. We have added Azure support. Cloud version of the application is based on Azure emulated environment provided by the SDK, so it hasn’t been tested on ‘real’ Azure scenario (we just do not have access to it).
**Any reviews, ideas and feedback are welcome!**
<a href='http://weblogs.asp.net/arturtrosin/archive/2010/12/10/c-domain-driven-design-sample-released.aspx'>here is more info about the release</a>

---

**!!!UPDATE - Dec 11, 2009!!!**
Here we are... the port is very close to finish and there are some important updates: 1. added Register App and Web Services for the App along with Folder Import Scanner, 2. SVN folder restructure and are added corresponding solution files in order to makeup separate organization\team development of Register App as it is in original ndddSample, 3. added Controllers layer Unit Tests, 4. and finally and most 'important' we have a brand new glamorous logo! thanks to Cornel Cretu.
<br> Next steps before release celebration are: 1. add readme with some explanations how to run, ect... 2. and maybe build scripts if they will be helpful. 3. Fix funny menu display in FireFox<br>
<hr />
<b>!!!UPDATE - Nov 12, 2009!!!</b>
Small updates, removed temporary Routing Service implementation and replaced with 'real' one :), as result new WCF host is added for that purpose NDDDSample.Interfaces.PathfinderRemoteService.Host. And of course ExternalRoutingService Tests are added to follow TDD approach :), to enable the tests was introduced Moq as mocking framework.<br>
<hr />
<b>!!!UPDATE - Nov 05, 2009!!!</b>
Finally I found the strengths to improve UI design of the site.  Also is added simple error handling management on the MVC UI layer and WCF services sides.<br>
Next main target and focus will be Incident Logging application.<br>
<hr />
<b>!!!UPDATE - Aug 11, 2009!!!</b>
<br />
For the moment the NDDD Sample is a workable DDD example based on Asp.net MVC which is UI part that is on top of domain model. Domain model is used by the Asp.net MVC: <br />1. In the same process –domain model is used by the MVC controllers,  accessing application services directly <br />2. External process – domain model logic is exposed by WCF services. In this case WCF service access remote facade and DTOs exposed by WCF services.<br>
<br />
User Interface is workable but is not nice, is hard for me to find strengths to develop nice pages :)<br>
<br>
So, Public Cargo Tracking interface and administration of Booking and Routing interface are DONE. Next: to develop WPF application that will allow registering handlings.<br>
<br />
Current Technology stack:<br>
<br />1.	NHibernate and Sql Lite<br>
<br />2.	Windsor Container<br>
<br />3.	Windsor WCF Facility<br>
<br />4.	WCF of course<br>
<br />5.	Asp.NET MVC<br>
<br />
enjoy :).<br>
<hr />
I would like to mention contributors; even most of the code for the moment was committed by me that doesn’t mean I’m the only contributor, so Ruslan Rusu, Eugen Gorgan and Victor Lungu spend their free time to discuss .NET specific decisions and Eugen Navitaniuc who helps with Java related questions.<br>
<br>
<blockquote>Artur Trosin</blockquote>

Quick link to the source: <a href='http://ndddsample.googlecode.com/svn/trunk/'><a href='http://ndddsample.googlecode.com/svn/trunk/'>http://ndddsample.googlecode.com/svn/trunk/</a></a>
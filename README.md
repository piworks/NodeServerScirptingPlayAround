# NodeServerScirptingPlayAround
A play around project for the possible tests of node.js capabilities and use cases on server side script rendering.

In certain cases we have the need to use our client code in server side to avoid code replication and stabil results such 
as exporting graphics normally rendered by browser. Currently for such purposes a phantomJS headles browser exe is placed in 
the project and the rendering of said actions takes place in this context. Given that the support for phantomJS is dead, 
we are turnig towards more popular and community driven node.js engine to perform such actions. 
So this project is mainly used for checking possible misbehaviour of our client code between node.js and actual browser.

# DocksideComputers

As part of my Level 3 Cambridge Technical IT qualification, we did a coursework on Application design (Unit 6) and Product development (Unit 9.) Through these two units we designed and built an application based on the requirements of a business.

This is the end-product of this course. It is a computer repair management system, designed for an SME to replace existing paper-based forms. It tracks customers and their computers throughout the process of troubleshooting, repair and payment, including displays that show outstanding tasks so that workers can't forget them.

It was based on Windows Forms with a C# backend and a mysql database for persistent storage.

## Improvements

There are a few improvements that I'd have like to make with this application, but completing them was out of scope of our project. The main ones were as follows:

* The GUI, while operational, should've been more accessible and allowed for resizing of displays. To do this, WPF rather than Forms would've been a great alternative.
* The database is accessed directly by the application, meaning the "login" is only enforced on the interface - there is no real security that could be done. This could be fixed by implementing a web API which the client connects to.
* The abilities of the search engine should've been improved with things like easier specifying of fields to search and fuzzy matching.

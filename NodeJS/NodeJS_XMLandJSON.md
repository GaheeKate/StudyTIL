# NodeJS : XML and JSON

Today I studied XML and JSON
- both JSON and XML are machine-readable and human-readable
- Loading data directly from the resource URL, can be slower especially when you are expecting a lot of traffic. -> Download the resource file and use it in the site -> if the data needs to be refreshed often, use API 
- XML (Extensible Markup Language) is a markup language made up of elements and attributes.
  - There is one root element
  - All elements must be closed
  - XML is not limited to a specific set of tags and semantics
  - XML is case-sensitive
  - follows the XML naming rules
    - must not contain spaces
    - must begin with letters or an underscore, but no other characters
    - must not contain the special character ":"
    - must not begin with "xml"

- XML DOM: DOM can be used
- XPath: XPath is a method of representing an XML node (can be element/attribute) as a path
> //person[.//first/text()='Harry']
- //: represents "descendant" (e.g. //first looks for a descendant element named "first"). If there is nothing before //, the query will return all matching elements which are descendants of the root of the document. If there is something before //, the query will return all matching descendants of the current node.
- element: text with no other symbols in a path represents an element name • @attr: attributes are prefixed with @ (e.g. //person/@id selects the id attribute for all descendent <person> elements)
- .: represents the current node 
-  ..: represents the parent element
- Predicates [<condition(s)>]: Predicates allow you to define conditions.
- Node tests
  - test()
  - position():This returns a number identifying the position

from lxml import etree
from lxml import objectify




print("hello")

a = 1

print(a)

filename = "C:\\Projects2\\Archytas\\Solutions\\TestData\\AscendProd\\Administration\\AscendProd.facilities"
filename = "C:\\Projects2\\Archytas\\Solutions\\TestData\\AscendProd\\Administration\\AscendProd.contacts"

file = open(filename, "r")



contents = file.read()[3:]
print(contents)

test = "<outside pone=\"A\"><inside ptwo=\"B\"/></outside>"

import xml.etree.ElementTree as ET
tree = ET.fromstring(contents)
tree = ET.parse(file)
ch = tree.getchildren

print(tree.attrib)
print(tree.tag)
print(ch[0].tag)


for child in tree:
    print(child.tag, child.find("FirstName").text)

child = tree[0][1]
for child in tree:
    print(child.find("FullName").text)

root = tree.getroot()


tree = objectify.fromstring(test)

print(tree)
file.close()

print(tree.size)

root = tree.Element("Facility")
b = objectify.SubElement(root, "b")
print(root.b[0].tag)
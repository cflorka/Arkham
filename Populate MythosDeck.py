import csv

startingLines = """using System;
using System.Collections.Generic;

namespace Arkham
{
	internal static class MythosDeck
	{
		static List<MythosCard> list = new List<MythosCard>();
		static List<MythosCard> List{get{return list;}}
		static MythosDeck()
		{"""
endingLines = """\n		}
	}
}"""
locDictionary = {}
locDictionary["Black Cave"] = "Cave.Instance"
locDictionary["Graveyard"] = "Graveyard.Instance"
locDictionary["Hibb's Roadhouse"] = "Roadhouse.Instance"
locDictionary["Historical Society"] = "HistSociety.Instance"
locDictionary["Independence Square"] = "IndependenceSq.Instance"
locDictionary["Science Building"] = "ScienceBuilding.Instance"
locDictionary["Silver Twilight Lodge"] = "Lodge.Instance"
locDictionary["The Unnamable"] = "Unnamable.Instance"
locDictionary["The Witch House"] = "WitchHouse.Instance"
locDictionary["Unvisited Isle"] = "UnvisitedIsle.Instance"
locDictionary["Woods"] = "Woods.Instance"

def addShapeToEach(shapeList):
	output = ""
	skinny = "".join(shapeList.split()) #removes whitespace
	if skinny:
		shapeListArr = skinny.split(",")
		arr = ["Shape." + shape for shape in shapeListArr]
		output = ", ".join(arr)
	return output

def cardFromRow(row):
	title = row[0]
	type = row[1]
	subtype = row[2]
	gateLoc = row[3]
	clueLoc = row[4]
	white = row[5]
	black = row[6]
	mythosAbility = row[7]
	rumorPass = row[8]
	rumorFail = row[9]
	outputString = ""
	outputString += "new " + type + "(" #open constructor
	outputString += "\"" + title + "\""
	if type == "Environment": outputString += ", EnvironmentType." + subtype
	outputString += "\n\t\t\t\t"
	outputString += ", \"" + mythosAbility + " Pass: " +  rumorPass + " Fail: " +  rumorFail + "\""
	outputString += "\n\t\t\t\t"
	if gateLoc: outputString += ", " + locDictionary[gateLoc]
	else: outputString += ", null"
	if clueLoc: outputString += ", " + locDictionary[clueLoc]
	else: outputString += ", null"
	outputString += "\n\t\t\t\t"
	outputString += ", " + "new Shape[]{" + addShapeToEach(white) + "}"
	outputString += ", " + "new Shape[]{" + addShapeToEach(black) + "}"
	outputString += ")" #closes constructor
	return outputString

with open('MythosCards.csv','r') as cardListRaw:
	with open('MythosDeck.cs','w') as mythosDeck:
		mythosDeck.write(startingLines)
		cardList = csv.reader(cardListRaw)
		cardList.next()
		for row in cardList:
			mythosDeck.write("\n\t\t\tlist.Add(" + cardFromRow(row) + ");")
		mythosDeck.write(endingLines)
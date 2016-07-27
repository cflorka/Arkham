import csv

cardList = open('MythosCards.csv','r')
mythosDeck = open('MythosDeck.cs','w')

for line in cardList:
	mythosDeck.write(line)

cardList.close()
mythosDeck.close()
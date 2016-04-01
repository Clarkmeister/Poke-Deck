/*************************************************************
* Authors: Ryan Bell & Arthur James Clark
* Date Created: 3/31/16
* Modification: 3/31/16 - Created Project
*               4/1/16  - Inital Git Commit
* Purpose: This program will simulate the Pokemon Trading Card game
*          For more information please see the read me documention
*
*
**************************************************************/

import QtQuick 2.5
import QtCanvas3D 1.0
import QtQuick.Window 2.2
import "glcode.js" as GLCode

Window
{
    title: qsTr("pokeDeck")
    width: 1920
    height: 1080
    visible: true
    Image
    {
        source: "pics/Pokemon_CB.jpg"

    }
}

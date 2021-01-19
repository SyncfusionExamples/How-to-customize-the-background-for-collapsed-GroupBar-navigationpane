# How-to-customize-the-background-for-collapsed-GroupBar-navigationpane
This repository contains the sample that how to customize the background for collapsed GroupBar navigationpane

The color of collapsed navigation pane can changed at the runtime when mouse entered/Clicked, using  the GroupBar mouse event handler. In that event the FloatHighlightButtonBorderColor and FloatPressCloseButtonColor property used to update the color of Navigation pane.

```C#:

//When collapsed navigation pane is clicked 

        private void GroupBar1_MouseClick(object sender, MouseEventArgs e)
        {
            Office2007BlueColors.Default.FloatPressCloseButtonColor = Color.Pink;
        }
```


```VB:

' When collapsed navigation pane is clicked 
Private Sub GroupBar1_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)
Office2007BlueColors.Default.FloatHighlightButtonColor = Color.Pink
End Sub
```

Output:

![GroupBar_NavigationPane_Customization](Output-GroupBar.gif)

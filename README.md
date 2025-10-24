# How to Customize the Background for Collapsed GroupBar Navigation Pane
This repository demonstrates how to **customize the background color for a collapsed GroupBar navigation pane** in a Windows Forms application using Syncfusion controls. The GroupBar control provides a navigation pane similar to Outlook, and when collapsed, it displays a compact view. In some cases, developers may want to change the appearance of this collapsed pane dynamically to match application themes or provide visual feedback on user interaction.

## Key Features Demonstrated in This Sample

    • Change the background color of the collapsed navigation pane at runtime.
    • Handle mouse events such as MouseEnter or MouseClick to apply custom styles.
    • Use Syncfusion’s built-in color properties like FloatHighlightButtonBorderColor and FloatPressCloseButtonColor for customization.

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

This approach allows developers to create visually appealing navigation panes that respond to user actions, improving the overall user experience. You can extend this logic to apply different colors based on themes or user preferences.

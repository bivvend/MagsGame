   M S B A M L   `   `   `  ����C  ?MagsGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MagsGame.BoardMagsGame.Board  5          MagsGame.Board.BoardView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:MagsGame.Board     5        � 	Resources  5	          BooleanToVisibilityConverter��%   &	        �� 5
   
   6'   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   6,   �� 5      $	��11* �6   6-   �� 5      $��1* �6   6,    � RowDefinitions 5   
   �� 5      $��1* �6   6*   �� 5      $	��11* �6   6+   �� 5      $��1* �6   6*   .+�5   
   �� $��1��6:   $��1��6J   ��6   ��  �� Path$ Board���5       �� 5!      .R�5"      A�  A� Columns 6"   �� *SizeX+ A� Rows 6<   �� *SizeY+5#      ��5%      �� 5&      .R�5'      �� 
�������.��5(      � .+�5)      �� $
��Fill=�6A   ��6$   �� *	ImageName+ J� InputBindings 5*   "   d� 5+   &    d� MouseAction$ 	LeftClicke�5,   %    �� Command 5-   %   �� 	 �� RelativeSource	 �� 
 �� AncestorType"
 ��$$ DataContext.SquareClickCommand� �� CommandParameter 5.   %   �� *Coords+5/   '   51      �� 52      $��AttackerMarker��6(   $��0q�6>   y�6J   �� *LavaPresent+ �� 	Converter# [  ��53   "   �� 54   &    �� ImageSource$, &/MagsGame;component/Resources/lava.jpg��61    j� Stretch$
 Fill=�6g   6x   56      �� 57      $��3q�6%   
��� � �y�6M   �� *
Selected+# [  6�   �� 58      $��3q�6%   
������y�6R   �� *Highlighted+# [  59      5:      5;      5<      5>      5?      5@      
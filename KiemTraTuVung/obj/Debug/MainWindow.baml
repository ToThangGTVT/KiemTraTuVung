   M S B A M L   `   `   `  ����O  KHọc tiếng Nhật, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Học_tiếng_NhậtHọc_tiếng_Nhật  5   	   %    Học_tiếng_Nhật.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Học_tiếng_Nhật     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          � Title$	  HTN��5	   	   $	��417��6   $	��449��6"    � WindowStartupLocation$ CenterScreen=�6.    � 
ResizeMode$ CanResizeWithGrip=�6S   $	��400��6�   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��163* �6   �� 5      $
��163* �6   .+�5   
   #  MaterialDesignThemes.Wpf.Card  -   5          Name$	 lbl��5      +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�5      ���	#FF2C3E50 !  PrimaryHueDarkForegroundBrush#���   5      $��25q�5         UniformCornerRadius$ 6Q�5      $��10,10,10,201q�5      $��2��5      $��Stretch=�5      .��5      � $��0,0,0,-3q�6   .+�5      �� -   5         ��Name$ txtCH��5      $
��Wrap=�6+   $��25(�6?   $	��371��6M    J� RenderTransformOrigin$ 0.5,0.5&�6Y   $��Center=�6y   	 �� TextAlignment$	 Center=�6�   �� 5      $2�,Mấy anh xài source ghi nguồn cho em nha��6   5      �� 5      $��3��6   $��0,0,0,6q�6(   $��Bottom=�69   ���	#FF455A64���	#FF37474F���	#FF455A646�   '  !MaterialDesignThemes.Wpf.PackIcon  5      
��� ����  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]
   Kind$
 StarRate=�6>   $��35��6N   $��20��6Z   $��	0,0,0,-23q�6e   $ 0,1.2&�6x   $��Bottom=�6�   �� 5       -   5        $
 txtD��5       $
��Left=�6*   $��
25,0,0,-20q�6E   $
��Wrap=�6Y   $��0��6m   $	��320��6v   $��23��6�   $��Bottom=�6�   5"      5%      �� 5&   
   -   5         ��Name$
 btnA��5&      $ Depth1=�5'        MaterialDesignRaisedButton#��[ 5(       � ToolTip$/ )Resource name: MaterialDesignRaisedButton��5)      $��
14,0,6,100q�6A   $��67��6U   $��Bottom=�6a   ���	#FF78909C���	#FF78909C#��� ��6�   $��16(�6�   .��6-  _A5+      � 5,   
   $
��Left=�6   $	��163��6*   $��	0,128,0,0q�67   $	��Top=�6J   $��0��6b   $��1��6l   �� 5-   
   -   5        $
 btnB��5-      $ Depth1=�5.      #��[ 5/      $/ )Resource name: MaterialDesignRaisedButton��50      $��
6,0,14,101q�6A   $��67��6U   ���	#FF78909C���	#FF78909C#��� ��6�   $��_B��6�   $��1��6�   $��Bottom=�6�   $��16(�6  6   �� 51   
   -   5        $
 btnD��51      $ Depth1=�52      #��[ 53      $/ )Resource name: MaterialDesignRaisedButton��54      $��	6,0,14,22q�6A   $��67��6T   ���	#FF78909C���	#FF78909C#��� ��6�   $��_C��6�   $��1��6�   $��Bottom=�6�   $��16(�6  6  �� 55   
   -   5        $
 btnC��55      $ Depth1=�56      #��[ 57      $/ )Resource name: MaterialDesignRaisedButton��58      $��	14,0,6,22q�6A   $��67��6T   ���	#FF78909C���	#FF78909C#��� ��6�   $��_D��6�   $��Bottom=�6�   $��16(�6  6  �� 59   
   -	   5        $��0��5:       0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 5;      $��Bottom=�5<      $��
0,0,66,181q�5=      $��40��6!   $��40��6-   $��1��6M   $��Right=�6]   ���	#FF00897B���	#FF00897B.��5>        $
 Arrow=�6&   $��20��63   $��20��6?   5?      �� 5@   
   -
   5        $��0��5A      #��[ 5B      $��Bottom=�5C      $��
0,0,21,181q�5D      $��40��6!   $��40��6-   $��1��6R   $��Right=�6b   ���	#FF00897B���	#FF00897B.��5E        $	
 Cog=�6&   $��20��61   $��20��6=   5F      �� 5H   
   -   5        $��0��5I      #��[ 5J      $��Bottom=�5K      $��0,0,111,181q�5L      $��40��6"   $��40��6.   $��1��6S   $��Right=�6c   ���	#FF00897B���	#FF00897B.��5M        $
 Talking=�6&   $��20��65   $��20��6A   5N      �� 5P   
   $��
7,0,214,-4q�6   $��2��6(   $��24��6<   $��Bottom=�6H   �� 5Q      -   5        $'��!https://www.facebook.com/tokun.nb?�5Q      .�6u   
Liên hệ5S      5T      �� 5U   
   -   5        $��0��5V      #��[ 5W      $��	14,15,0,0q�5X      ���	#FF78909C���	#FF78909C$��40��6c   $	��Top=�6o   $
��Left=�6�   $��40��6�   .��5Y        $	
 Add=�6&   $��20��61   $��20��6=   5Z      5[      5\      
   M S B A M L   `   `   `  ����  Học tiếng Nhật&     Học_tiếng_Nhật.Them_tu_moi   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          �Name$  them_tu_moi��5   	    � Title$	 HTN��5   	   $	��417��6   $	��450��6"    � WindowStartupLocation$ CenterScreen=�6.    � 
ResizeMode$ CanResizeWithGrip=�6S   $	��400��6r    � 	Resources 5
         key1 �� Text��%)   &	        �� 5   
   $ Enter��6'   5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command# [  5      5       J� InputBindings 5      �� 5   
   
	 �� Key$	 Enter��6   
 �� Command#
 [  6!   6C   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��110* �6   �� 5      $��0* �6   �� 5      $
��111* �6   .+�5   
   �� -   5         ��Name$ 	lst_excel��5      $��3��5    ,   $��
0,100,0,10q�6@   $��0��6T   ��6   �� *Items1+ �� View 5!      �� 5"      .P�5#      �� $	��STT��5%       �� DisplayMemberBinding 5$      �� *STT+5%      �� 5&      $��English��5(       5'      �� *Eng+5(      �� 5)      $��
Vietnamese��5+       5*      �� *Vie+5+      5,      5.      �� 5/   
   -   5         ��Name$ txt_Vie��50      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Vietnamese��51       % !MaterialDesignFloatingHintTextBox#��[ 52      $��
10,10,10,0q�6H   $��45��6\   $	��Top=�6h   $��1��6�   $��2��6�   $��2��6�   �� 53   
   -   5        $ txt_Eng��54      $ English��55      #��[ 56      $��
10,10,10,0q�6H   $��45��6\   $	��Top=�6h   $��1��6�   �� 57   
   -   5        #��[  58        MaterialDesignRaisedButton#��[ 59       � ToolTip$X RThêm các từ tiếng Anh và tiếng Việt cần học vào bảng ở dưới��5:      $��	10,65,0,0q�6S   $��30��6f   $	��Top=�6r   ���	#FF78909C���	#FF78909C$
��Left=�6�   $��95��6�   $��3��6�   .��6  Thêm thẻ5=      �� 5>   
   -   5        #��[ 5?      $n hXóa các từ tiếng Anh và tiếng Việt cần học vào bảng ở dưới sau khi chọn 1 thẻ��5@      $��
110,65,0,0q�6e   $
��Left=�6y   $��90��6�   $��30��6�   $	��Top=�6�   $��
Xóa thẻ��6�   ���	#FF78909C���	#FF78909C$��0��6  d� 5A   
   -   5         d�Name$ btn_htm��5B       ( $MaterialDesignSwitchDarkToggleButton#��[ 5C      $* $MaterialDesignSwitchDarkToggleButton��5D      $��0,65,7,0q�6<   $��2��6N   $��Right=�6^   $��45��6z   $��30��6�   $	��Top=�6�   $�� ��6�   6�   �� 5E   
   $
��Bold"�5F      $��	0,71,57,0q�6$   $��2��67   $��Right=�6G   $��69��6c   $��24��6n   $	��Top=�6z   ���	#FF838383Học từ mới:5H      5I      5J      
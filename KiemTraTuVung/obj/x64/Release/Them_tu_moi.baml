   M S B A M L   `   `   `  ����   Học tiếng Nhật&     Học_tiếng_Nhật.Them_tu_moi   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     �Name$  them_tu_moi�� � Title$	 HTN��$	��417��$	��450�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ CanResizeWithGrip=�$	��400�� � 	Resources    key1 �� Text��%   &	        �� $ Enter�� J� CommandBindings )  #System.Windows.Input.CommandBinding  -      Command# [   J� InputBindings �� 
	 �� Key$	 Enter��
 �� Command#
 [  .���  � ColumnDefinitions �� $
��110* ��� $��0* ��� $
��111* �.+��� -    ��Name$ 	lst_excel��$��3��$��
0,100,0,10q�$��0������ *Items1+ �� View �� .P��� $	��STT�� �� DisplayMemberBinding �� *STT+�� $��English�� �� *Eng+�� $��
Vietnamese�� �� *Vie+�� -    ��Name$ txt_Vie��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Vietnamese�� % !MaterialDesignFloatingHintTextBox#��[ $��
10,10,10,0q�$��45��$	��Top=�$��1��$��2��$��2���� -   $ txt_Eng��$ English��#��[ $��
10,10,10,0q�$��45��$	��Top=�$��1���� -   #��[    MaterialDesignRaisedButton#��[  � ToolTip$X RThêm các từ tiếng Anh và tiếng Việt cần học vào bảng ở dưới��$��	10,65,0,0q�$��30��$	��Top=����	#FF78909C���	#FF78909C$
��Left=�$��95��$��3��.��Thêm thẻ�� -   #��[ $n hXóa các từ tiếng Anh và tiếng Việt cần học vào bảng ở dưới sau khi chọn 1 thẻ��$��
110,65,0,0q�$
��Left=�$��90��$��30��$	��Top=�$��
Xóa thẻ�����	#FF78909C���	#FF78909C$��0��d� -    d�Name$ btn_htm�� ( $MaterialDesignSwitchDarkToggleButton#��[ $* $MaterialDesignSwitchDarkToggleButton��$��0,65,7,0q�$��2��$��Right=�$��45��$��30��$	��Top=�$�� ���� $
��Bold"�$��	0,71,57,0q�$��2��$��Right=�$��69��$��24��$	��Top=����	#FF838383Học từ mới:
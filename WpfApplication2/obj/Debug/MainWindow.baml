   M S B A M L   `   `   `  ����P  LStudentsWorkAnalytics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:StudentsWorkAnalyticsStudentsWorkAnalytics  5   	   m iSystem.Windows.Forms.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35�mclr-namespace:System.Windows.Forms.DataVisualization.Charting;assembly=System.Windows.Forms.DataVisualization/System.Windows.Forms.DataVisualization.Charting 5   	   Y1clr-namespace:StudentsWorkAnalytics.ElementsClass#StudentsWorkAnalytics.ElementsClass  5	   	   &     StudentsWorkAnalytics.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:StudentsWorkAnalytics     5   	   �winformchartmclr-namespace:System.Windows.Forms.DataVisualization.Charting;assembly=System.Windows.Forms.DataVisualization     5   	   ?l1clr-namespace:StudentsWorkAnalytics.ElementsClass     5	   	     � Title$  Students Work Analytics��5   	   $��448.272��6)   $��706.61��6:    � 
ResizeMode$ CanResizeWithGrip=�6I   $	��300��6h   $	��300��6w    � WindowStyle$
 None=�6�    � Icon$ ico.png��6�    � 	Resources 5      7   1StudentsWorkAnalytics.ElementsClass.MathConverter   MathConverter  SelectedBorderBrush �� 
StartPoint �� EndPoint � Color � Offset	 �� 
TargetType
 �� Property �� Value �� 
TargetType �� CornerRadius K� ZIndex ��Name �� Triggers P� Property P� Value �� 
TargetName  FocusVisual J� SnapsToDevicePixels �� StrokeDashArray��%�  &	        &	      '�� �     7  &	 �    '�� p      5   
   6   �� 5   
   $	 0,0&�6:   $	 1,0&�6K   ��5      � � 5      $
 Gray��6#   $ 0.965Q�60   � 5      $ 
WhiteSmoke��6#   $	 1.0Q�66   5      5      �� 5   
   "	 ��6   .�5      �� 
 � �� 5      �� 5      " ��6&   .R�5      � .+�5      �� $��Border��6%   ���	#AADDDDDD$ 0,0,0,0��5      
�������$��0,0,0,0q�5!      $ 50��5"      $��0,0,0,0q�5#      ._�5&   "   �� $ ContentSite��63   $��Center=�5'   !   $
��Left=�5(   !   $��Header��5)   !   $��10,10,10,10q�5*   !   5+      5,       5-      P� 5.       �@��
IsSelected . . �5/   "   �� 
 �@K�ZIndex$	 100��6A   �� 50   "   
 � ��$ 0,0,0,0q�6;   �� 51   "   $ Border��6)   8   
 � ��53   %   �� 54   "   $ Border��6)   
 � ��
 �����56   !   �� 57   "   $ Border��6)   
 �@��CornerRadius$ 0,0,0,0��59   !   5:      5<      5>      5?      �� 5@   
   .�5A      �� 
 � �� 5B      �� 5C      .R�5D      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5E      5G      5H      �� 5I   
   "	 ��6   .�5J      �� 
 � ��$ Center=�64   5K      5L      .��5M      � .+�5N   
   �� -   5         ��Name$ 
tabControl��5N      
�������$��0,15,0,0q�6=   $��Center=�6O   .@�5O      �� $��Model settings��6   .��5P      � 
�������.+�5Q      �� -   5         ��Name$ button1��5Q      $��Add new parameter��6.   $��44.519��6J   $��10,10,118.471,0q�6Z   $	��Top=�6s     ButtonMainStyle_White#���  6�   �� 5R      $��0,59.519,0,0q�6#   .��5S      � -   5         �Name$ StackParams��5S   $   ���	#FFE2E2E2��. $��10,0,0,0q�6u   5T      �� 5U      -   5        $ btn_SaveParemetersToXML��5U      $��Save Parameters��6>   $��	0,10,10,0q�6X   $	��Top=�6k   #���  6�   $��Right=�6�   $��103.471��6�   �� 5V      -   5        $ btn_LoadParameters��5V      $��Load Parameters��69   $��0,34.559,10,0q�6S   $	��Top=�6j   #���  6�   $��Right=�6�   $��103.471��6�   5W      5X      �� 5Y      $��Add Work��6   $��Stretch=�6(   .��5Z      � 
�������.+�5[      �� $��
10,38,0,67q�6#   $��Stretch=�67   $��Stretch=�6\   .��5\      �� -   5         ��Name$ sp_ParametersInput��5\   %   5]      �� 5^      -   5         ��Name$ tBl_Name��5^      
 � Tag$
 Name��60   $
��Left=�6;   $��23��6V   $��	10,10,0,0q�6b    �� TextWrapping$
 Wrap=�6u   $
��Name��6�   $	��Top=�6�   $	��144��6�     TextBoxStyle_White#���  6�   6�   �� 5_      -   5        $ tBl_Surname��5_      $ Surname��63   $��23��6A   $��
159,10,0,0q�6M   $
 Wrap=�6a   $��Surname��6u   $	��Top=�6�   #���  6�   $
��Left=�6�   $��168.333��6�   6  �� 5`      -	   5        $ 	tBl_Group��5`      $ Group��61   $��23��6=   $��332.333,10,0,0q�6I   $
 Wrap=�6a   $��Group��6u   $	��Top=�6�   #���  6�   $
��Left=�6�   $��78.667��6�   6  �� 5a      -
   5        $ btn_AddStudentsWork��5a      $	��Add��6:   $��416,10,10,0q�6H   $	��Top=�6   $��23��6�   #���  6�   � 5b      $��70��6   $��Bottom=�6'   $��
-3,0,-3,-3q�6B   ��5c      �� 5d      $ 0.5,1&�62   $ 0.5,0&�6C   .��5e   "   � $ 	#FF4B8355��6/   $ 1Q�6A   � 5f   "   $ 	#FF88FF9D��6/   $ 0.753Q�6A   5g      .+�5i      �� -   5         ��Name$ tBl_Mark��5i   $   $��0q�66   $
��Wrap=�6A   $
��MARK��6U   $��Center=�6a   $��36(�6|   $��62��6�   $��Center=�6�   $
��Bold"�6�   5j      5k      5l      �� 5m      $��Analysis��6   .��5n      � 
�������.+�5o      �� -   5        $ tb_DB_search_Analysis��5o      $ Search��6=   $��23��6J   $��
30,10,10,0q�6V   $
 Wrap=�6j   $	��Top=�6~   #���  6�   $��Search��6#  �� 5p      -   5         ��Name$ 
image_Copy��5p      $
��Left=�60   $��14��6K   $��10,14.5,0,0q�6W   $	��Top=�6l   $��15��6�   $��cloudvideo30.gif��6�   �� 5q      $��0,38,0,0q�6#   $	��Top=�65   $	��100��6M   .��5r      �� -   5        $ sp_Works_Analysis��5r   %   5s      �� 5t      $��	0,138,0,0q�6#   ���	#FFE8E8E8$��Visible=�6M   $��Disabled=�6u   .��5u      �� -   5        $ sp_Analysis_Charts��5u   %    �� Orientation$ 
Horizontal=�6A   $
��Left=�6Z   .+�5v      7  1System.Windows.Forms.Integration.WindowsFormsHost  -   5           Name$  host1��5v   /   $��0q�6>   ��6I   �� *ActualHeight+! �� ConverterParameter$! ((@VALUE)*2.5)��" �� 	Converter#" [  # �� ElementName$# host1��$   Child.$ 5w   "   ;  5System.Windows.Forms.DataVisualization.Charting.Chart  -   5        chart_ParallelCoordinates��[ WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"  System.Windows.Forms.Control%   Dock$
% Fill=�5w   X   &   Series& 5x   &   <  6System.Windows.Forms.DataVisualization.Charting.Series  5y   *   '   Name$' series��6>   (   	ChartType$( Spline=�6L   )   	ChartAreaM  GSystem.Windows.Forms.DataVisualization.Charting.SeriesAreaNameConverter$) TestCA 6_   *   
ChartAreas* 5{   &   ?  9System.Windows.Forms.DataVisualization.Charting.ChartArea  5|   *   +   Name$+ TestCA��6A   5~   #   5        5�      -   5        $  host2��5�   /   $��0q�6>   ��6I   �� *ActualHeight+$! ((@VALUE)*2.5)��#" [  $# host2��.$ 5�   "     -   5        chart_MarksDots��$
% Fill=�5�   N   & 5�   &     5�   *   $' series��6>   $( Point=�6L   $) TestCA 6^   * 5�   &     5�   *   $+ TestCA��6A   5�   #   5�      5�      5�      5�      5�      �� 5�      $��	Data Base��6   $��Stretch=�6)   .��5�      � 
�������, � ColumnDefinitions, 5�      �� 5�      $
��200* �6+   �� 5�      $
��200* �6+   .+�5�      �� $��
10,38,0,10q�6#   ���	#FFF7F7F7.��5�      �� -   5        $ sp_DataBase��5�   %   ���	#FFBFBFBF$
��Auto=�6Q   $	��Top=�6�   5�      �� 5�      $��15.5,53.96,10,97.76q�6#   $��1��6@   .��5�      �� -   5        $ sp_CurrentParamsInDB��5�   %   ���	#FFF7F7F7$
��Auto=�6Z   5�      �� 5�      -   5        $ 
tb_DB_Name��5�      $��23��62   $��14,25.96,0,0q�6>   $
 Wrap=�6T   $
��Name��6h   $	��Top=�6t   $��1��6�   #���  6�   $
��Left=�6�   $��128.195��6�   $
 Name��6$  ���	#FFC8C8C86/  �� 5�      -   5        $ tb_DB_Surname��5�      $ Surname��65   $��23��6D   $��146.5,25.96,0,0q�6P   $
 Wrap=�6i   $��SurName��6}   $	��Top=�6�   $��1��6�   #���  6�   $
��Left=�6�   $	��120��6�   6  �� 5�      -   5        $ tb_DB_Group��5�      $ Group��63   $��23��6?   $��271.5,25.96,0,0q�6K   $
 Wrap=�6d   $��Group��6x   $	��Top=�6�   $��1��6�   #���  6�   $
��Left=�6�   $��68.805��6�   6  �� 5�      -   5        $ tBl_DB_Number��5�       $��	14,10,0,0q�67   $
��Wrap=�6J   $��Number��6^   $	��Top=�6l   $��1��6�   $
��Left=�6�   �� 5�      -   5        $ btn_DB_test��5�      $
��test��62   $��102.167,0,10,10q�6A   $��1��6t   #���  6�   $��32.84��6�   $��Bottom=�6�   �� 5�      -   5        $ AddStWorkInDB��5�      $��Add Work��64   $��15.5,0,0,10q�6G   $��1��6x   #���  6�   $
��Left=�6�   $��81.667��6�   $��82.76��6�   $��Bottom=�6�   �� 5�      -   5        $ tb_DB_search��5�      $ Search��64   $��23��6A   $��	30,10,0,0q�6M   $
 Wrap=�6`   $	��Top=�6t   #���  6�   $��Search��6  �� 5�      -   5        $ image��5�      $
��Left=�6+   $��14��6F   $��10,14.5,0,0q�6R   $	��Top=�6g   $��15��6   $��cloudvideo30.gif��6�   �� 5�      -   5        $  btn_SaveStudentsWorksToXML��5�      $(��"Save Students Works and Parameters��6A   $��102.167,0,10,72.8q�6n   $��Bottom=�6�   $��1��6�   #���  6�   6�   �� 5�      -   5        $$ btn_LoadStudentsWorksData_Copy��5�      $(��"Load Students Works and Parameters��6E   $��1��6r   $��102.167,0,10,47.84q�6�   $��Bottom=�6�   #���  6�   6�   5�      5�      5�      � 5�   
   -    5        $��15��5�      $	��Top=�6   
�������.+�5�      �� -!   5        $ image1��5�      $
��Left=�6$   $��12.75��6?   $��ico.png��6M   5�      �� 5�   
   -"   5        $ 	btn_Close��5�      $�� ��6$   $��Right=�6/   $	��Top=�6K   $��12��6c     btn_Close_style#���  6n   - �� IsCancel- . $��12��6�   $��0,3,3.667,0q�6�   ���	#FF99763A6�   �� 5�   
   -#   5        $ btn_Maximaze��5�      $�� ��6'   $��Right=�62   $	��Top=�6N   $��12��6f   $��0,3,20.667,0q�6q     btn_MaximizeStyle#���  6�   - . $��12��6�   ���	#FFA0881C6�   �� 5�   
   -$   5        $ btn_Minimaze��5�      $�� ��6'   $��Right=�62   $	��Top=�6N   $��12��6f   $��0,3,37.667,0q�6q     btn_MinimazeStyle#���  6�   - . $��12��6�   ���	#FFAE99546�   �� 5�   
   -%   5        $ 	textBlock��5�      $
��Left=�6'   $
��Wrap=�6B   $��Student's Works Analytics��6V   $	��Top=�6w   $��20,0,0,0q�6�   5�      5�      
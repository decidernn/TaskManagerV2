   M S B A M L   `   `   `  ����G  CTask_Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Task_ManagerTask_Manager  5          Task_Manager.AddTeam   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      &localclr-namespace:Task_Manager  5        N� Title$  AddTeam��5
      .��5      � .+�5   
   �� $��63,202,63,324q�6   .+�5      �� -   5        $��txtNameTeam��5   )   $��	25,60,0,0q�6   $��16(�6<   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$% Название команды��5   "   $��2q�6T      MaterialDesignDivider#���   5   "    ! MaterialDesignOutlinedTextBox#��[ 6X   $��54��6�   $	��350��6�   $��1��6�   �� 5      -   5        $��txtSpecification��5   )   $��	25,20,0,0q�6   $��16(�6A   $% Название команды��5   "   $��2q�6T   #���   5   "   #��[ 6X   $��54��6�   $	��350��6�   $��1��6�   5      �� 5   
   $��Участники��6   $
��Left=�6$   $��
10,586,0,0q�6?   $	��Top=�6S   $��20(�6k   $��Segoe UI Semibold)�6y   �� 5   
   -   5        $��btnSave��5   &   $��352,0,0,238q�6    ! MaterialDesignFlatMidBgButton#��[ 65   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth0=�5      $��47��6B   $	��230��6N   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5      $��18(�6?   $��Сохранить��6M   $��Bottom=�6w   $
��Left=�6�   �� 5   
   -   5        $��btnBack��5   &   $��600,0,0,238q�6   #��[ 65   $ Depth0=�5       $��47��6B   $	��230��6N   $ 10��5!      $��18(�6?   $��
Назад��6M   $
��Left=�6s   $��Bottom=�6�   �� 5#   
   -   5        $��btnEdit��5#   &   $��846,0,0,238q�6   #��[ 65   $ Depth0=�5$      $��47��6B   $ 10��5%      $��18(�6?   $ ��Редактировать��6M   $
��Left=�6{   $	��331��6�   $��Bottom=�6�   &   System.Windows.Controls.DataGrid  5'   
   -   5          Name$ dgUsers��5'         AutoGenerateColumns .     
IsReadOnly . $
��1200��6R   $��Center=�6_   $��
0,626,0,10q�6|      Columns 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6R   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 66   �� *	surname+6R     5*      $ Имя��6%   $	 * 6K   
 62   �� *name+6K   5,      5.      5/      
   M S B A M L   `   `   `  ����I  EJosePutoAmoWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:JosePutoAmoWPFJosePutoAmoWPF  5   	       JosePutoAmoWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:JosePutoAmoWPF     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5        $��sliderImagenes��5   !   $��0��6   $	��100��67    � Minimum$ 0Q�6C    � Maximum$ 3Q�6O   $��Center=�6[    � Value$ 0Q�5      6   �� 5   
   -   5        $��
imgElegida��5       $��1��6   $	��200��62   $	��200��6>   $$��Imagenes/OCT_1_PeorEnemigo.png��5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��	dgDibujos��5      $��1��5      $��2��6    $��2��64      AutoGenerateColumns . $ �� IsSynchronizedWithCurrentItem$
 TrueY�5         RowDetailsVisibilityMode$ 	Collapsed=�5      	   
IsReadOnly	 . 
   SelectionMode$
 Single=�5      5       5!      5"      
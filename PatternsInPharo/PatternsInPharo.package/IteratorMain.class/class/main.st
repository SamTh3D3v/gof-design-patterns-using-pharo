accessing
main
| collect iterator item|
collect := Aggregate new.
collect add:'item 1'.
collect add:'item 2'.
collect add:'item 3'.
collect add:'item 4'.
collect add:'item 5'.

iterator := Iterator new.
iterator aggregate: collect.
item:=iterator firstItem.
[ item ~= nil ] whileTrue: [ self inform: item. item:= iterator nextItem ]






accessing
main
| observable observer1 observer2|
observable := Observable new.
observer1 := Observer new.
observer2 := Observer new.

observer1 subscribeTo:observable announcer.
observer2 subscribeTo:observable announcer.

observable SomeData: 'update'

### 1 Which functional / non-functional flaws can you identify from this specification?

- Functional flow: getting content of JSON over url, deserializaion of JSON content, adding deserialized content in creating Objects, showing results. 

- Non-functional flow: creating classes that are modeled on current JSON content. 


### 2 Considering the whole system, which failure points can you identify?
- This program doesn't work with every JSON url, because classes are modeled on current JSON content.

### 3 How would you notify the user if there are issues with execution of the application?
- Using try, catch to notify user for unusual program behavior (not implemented in this program) .

### 4 How would you measure performance of this application?
- Measuring performance using: VS Diagnostic tools, Intel VTune Amplifier and ANTS Performance Profiler.

### 5 How would you stress-test this application?
- Stress-test of this application: Using extreme inputs (large JSON content), running app on computer with extreme low specification, running programs on extremely slow internet connection.

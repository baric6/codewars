
def move_zeros(lst):
    # count
    zeroCount = 0
    for i in lst:
        if i == 0:
            zeroCount+=1

    # remove zeros
    lst = list(filter(lambda x: x != 0, lst))

    # add all the zeros that was counted to the end
    for i in range(zeroCount):
        lst.append(0)      

    return lst

print(move_zeros([9, 0, 0, 9, 1, 2, 0, 1, 0, 1, 0, 3, 0, 1, 9, 0, 0, 0, 0, 9]))
#                [9, 9, 1, 2, 1, 1, 3, 1, 9, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0]
#############################################################################





# a way i found how to do it
# this is a better way to do it unserstanbly 
def move_zeros1(array):
    
    '''Returns an array of integers with the 0's at the end
       input: an array of integers
       output: an array of integers'''#
    
    for i in array: #traverse the array
        if i == 0: #checks if 'i' is equal to 0
            array.remove(0) #remove a 0 everytime we find one
            array.append(0) #appends a 0 everytime we find one
    return array #returns the updated array

print(move_zeros1([9, 0, 0, 9, 1, 2, 0, 1, 0, 1, 0, 3, 0, 1, 9, 0, 0, 0, 0, 9]))
#                 [9, 9, 1, 2, 1, 1, 3, 1, 9, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0]
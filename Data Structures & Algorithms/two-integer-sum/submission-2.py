class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        visited = {}
        for i in range(len(nums)):
            d = target - nums[i]
            if d in visited:
                return [visited[d],i]
            else:
                visited[nums[i]] = i
        return []


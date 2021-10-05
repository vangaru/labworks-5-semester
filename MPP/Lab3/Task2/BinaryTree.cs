using System;
using System.Collections;
using System.Collections.Generic;

namespace Task2
{
    public class BinaryTree : IEnumerable
    {
        private TreeNode _head;
        public void Add(DictionaryItem value)
        {
            if (_head == null)
                _head = new TreeNode { Value = value };
            else
                AddTo(_head, value);
        }

        private void AddTo(TreeNode node, DictionaryItem value)
        {
            switch (value.CompareTo(node.Value))
            {
                case < 0:
                    AddToLeft(node, value);
                    break;
                case > 0:
                    AddToRight(node, value);
                    break;
                default:
                    node.Value.Count++;
                    break;
            }
        }

        private void AddToLeft(TreeNode node, DictionaryItem value)
        {
            if (node.Left == null)
                node.Left = new TreeNode { Value = value };
            else 
                AddTo(node.Left, value);
        }

        private void AddToRight(TreeNode node, DictionaryItem value)
        {
            if (node.Right == null)
                node.Right = new TreeNode { Value = value };
            else 
                AddTo(node.Right, value);
        }

        public void Remove(DictionaryItem value)
        {
            var current = GetNodeWithParent(value, out var parent);

            if (current == null)
                throw new ArgumentException("Values doesnt exist in container", nameof(value));

            if (current.Right == null)
                RemoveIfHasOnlyLeftChild(current, parent);
            else if (current.Right.Left == null) 
                RemoveIfHasRightChildWithoutLeftChild(current, parent);
            else
                RemoveIfHasRightChildWithLeftChild(current, parent);
        }

        private TreeNode GetNodeWithParent(DictionaryItem value, out TreeNode parent)
        {
            var currentNode = _head;
            parent = null;

            while (currentNode != null)
            {
                if (currentNode.CompareTo(value) > 0)
                {
                    parent = currentNode;
                    currentNode = currentNode.Left;
                }
                else if (currentNode.CompareTo(value) < 0)
                {
                    parent = currentNode;
                    currentNode = currentNode.Right;
                }
                else break;
            }

            return currentNode;
        }

        private void RemoveIfHasOnlyLeftChild(TreeNode node, TreeNode nodeParent)
        {
            if (nodeParent == null)
                _head = node.Left;
            else
            {
                var result = nodeParent.CompareTo(node.Value);
                switch (result)
                {
                    case > 0:
                        nodeParent.Left = node.Left;
                        break;
                    case < 0:
                        nodeParent.Right = node.Left;
                        break;
                }
            }
        }

        private void RemoveIfHasRightChildWithoutLeftChild(TreeNode node, TreeNode nodeParent)
        {
            if (node.Right == null) return;
            node.Right.Left = node.Left;
            if (nodeParent == null)
                _head = node.Right;
            else
            {
                var result = nodeParent.CompareTo(node.Value);
                switch (result)
                {
                    case > 0:
                        nodeParent.Left = node.Right;
                        break;
                    case < 0:
                        nodeParent.Right = node.Right;
                        break;
                }
            }
        }

        private void RemoveIfHasRightChildWithLeftChild(TreeNode node, TreeNode nodeParent)
        {
            if (node.Right == null) return;
            var leftmost = node.Right.Left;
            var leftmostParent = node.Right;
            while (leftmost is { Left: { } }) 
            {
                leftmostParent = leftmost; leftmost = leftmost.Left;
            }

            if (leftmost == null) return;
            leftmostParent.Left = leftmost.Right;
            leftmost.Right = node.Right;
            if (nodeParent == null)
            {
                _head = leftmost;
            }
            else
            {
                var result = nodeParent.CompareTo(node.Value);
                switch (result)
                {
                    case > 0:
                        nodeParent.Left = leftmost;
                        break;
                    case < 0:
                        nodeParent.Right = leftmost;
                        break;
                }
            }
        }

        public void TraverseInOrderEnglishVariant()
        {
            TraverseInOrderAfterEnglishVariant(_head);
        }

        private static void TraverseInOrderAfterEnglishVariant(TreeNode parent)
        {
            if (parent == null) return;
            TraverseInOrderAfterEnglishVariant(parent.Left);
            Console.WriteLine(parent.Value.ToString());
            TraverseInOrderAfterEnglishVariant(parent.Right);
        }

        public void TraverseInOrderRussianVariant()
        {
            TraverseInOrderAfterRussianVariant(_head);
        }

        private static void TraverseInOrderAfterRussianVariant(TreeNode parent)
        {
            if (parent == null) return;
            TraverseInOrderAfterRussianVariant(parent.Left);
            Console.WriteLine(parent.Value.ToRussianVariantString());
            TraverseInOrderAfterRussianVariant(parent.Right);
        }

        public List<DictionaryItem> ToList()
        {
            var dictionaryItems = new List<DictionaryItem>();
            TraverseIntoList(_head, ref dictionaryItems);
            return dictionaryItems;
        }

        private static void TraverseIntoList(TreeNode parent, ref List<DictionaryItem> dictionaryItems)
        {
            if (parent == null) return;
            TraverseIntoList(parent.Left, ref dictionaryItems);
            dictionaryItems.Add(parent.Value);
            TraverseIntoList(parent.Right, ref dictionaryItems);
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}